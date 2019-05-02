using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace duoapi.v1
{
    //public class 
    public class  BulkBucket<T>
    {
        private  List<T> InstertItems = new List<T>();
        private string TableName;
        private List<string> Columns;

        public BulkBucket(string tableName, List<string> WhereCloseColumns)
        {
            TableName = tableName;
            Columns = WhereCloseColumns;
        }

        public void Add(T Item)
        {
            InstertItems.Add(Item);
        }
        
        public string Get_BulksertScript()
        {
            string values = GetValues();
           
            string wherecoloums = GetWhere();
            string UpdateColums = "";
            string InsertValues = "";
            string slection = GetObjectColumns(out InsertValues,out UpdateColums);
            string str= "MERGE "+TableName+ " AS t USING(VALUES ("+ values + ")) As s "+ slection+" On "+ wherecoloums + " ";
            str += " WHEN MATCHED THEN  UPDATE SET " + UpdateColums;
            str += " WHEN NOT MATCHED THEN   INSERT " + slection;
            str += " VALUES " + InsertValues +";";
            //str = @"";
            return str;
        }


        public string Get_BulkUpdate()
        {
            string values = GetValues();

            string wherecoloums = GetWhere();
            string UpdateColums = "";
            string InsertValues = "";
            string slection = GetObjectColumns(out InsertValues, out UpdateColums);
            string str = "MERGE " + TableName + " AS t USING(VALUES (" + values + ")) As s (" + slection + ") On " + wherecoloums + " ";
            str += " WHEN MATCHED THEN  UPDATE SET " + UpdateColums+";";
            
            
            return str;
        }

        private string GetValues()
        {
            string str = "";
            foreach(var item in InstertItems)
            {
                str += "(";
                var prps=item.GetType().GetProperties();
                foreach(var col in prps)
                {
                     
                    switch (col.PropertyType.Name)
                    {
                        case "String":
                            str += "'"+col.GetValue(item, null).ToString()+"',";
                            break;
                        case "Int16":
                            str += "" + col.GetValue(item, null).ToString() + ",";
                            break;
                        case "Int32":
                            str += "" + col.GetValue(item, null).ToString() + ",";
                            break;
                        case "Int64":
                            str += "" + col.GetValue(item, null).ToString() + ",";
                            break;
                        case "Decimal":
                            str += "" + col.GetValue(item, null).ToString() + ",";
                            break;
                        case "DateTime":
                            str += "'" + Convert.ToDateTime(col.GetValue(item, null)).ToString("MM/dd/yyyy HH:mm:ss") + "',";
                            break;

                    }
                }
                str= str.Substring(0, str.Length - 1)+"),";
            }
            return str.Substring(0,str.Length - 1);
        }

        private string  GetObjectColumns(out string InsertValues,out string updateValues)
        {
            string selection = "";
            InsertValues = "";
            updateValues = "";
            var props = typeof(T).GetProperties();
            
            foreach(var ss in props)
            {
                string key = ss.Name;
                var result = Columns.Where(s => s == key).ToList();
                //Columns.Select("")
                if (result.Count == 0)
                {
                    updateValues += key + "= " + "s." + key + ",";
                }
                selection += key + ",";
                InsertValues += "s."+key+",";
                
            }

            InsertValues = InsertValues.Substring(0,InsertValues.Length - 1);
            selection = selection.Substring(0,selection.Length - 1);
            updateValues = updateValues.Substring(0,updateValues.Length - 1);

            return selection;
        }

        private string GetWhere()
        {
            string str = "";
            foreach (string column in Columns)
            {
                str += " s."+column+" = t."+column+" And";
            }
            str = str.Substring(0,str.Length - 3);
            return str;
        }

        public void Update(SqlConnection Con)
        {
            try
            {
                if (Con.State == System.Data.ConnectionState.Open) {
                    SqlCommand sqlCommand = new SqlCommand(Get_BulkUpdate(),Con);
                    int result= sqlCommand.ExecuteNonQuery();
                    InstertItems = new List<T>();
                }
                else
                {
                    using (StreamWriter str = new StreamWriter("ErorrLog_BullUpdate.log", true))
                    {
                        str.WriteLine(Get_BulkUpdate());
                    }
                    //throw new Exception("Connection is Closed Please Send a Open Connection.");
                }

            }
            catch(Exception Ex)
            {
                using (StreamWriter str = new StreamWriter("ErorrLog_BullUpdate.log", true))
                {
                    str.WriteLine(Get_BulkUpdate());
                }
            }
        }
    }
}
