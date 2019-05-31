using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
 
    public class LedgerTransactions
    {
        public LedgerTransactions()
        {

        }

        public LedgerTransactions(string _gulcoid, string _source,string _gurefid,string _refid, string _guaccountid, string _description, decimal _credit, decimal _debit)
        {
            gulcoid = _gulcoid;
            source = _source;
            gurefid = _gurefid;
            refid = _refid;
            guaccountid = _guaccountid;
            credit = _credit;
            debit = _debit;
            description = _description;
            trandatetime = DateTime.Now;
            createdate = DateTime.Now;
            /*
            gulcoid = _gulcoid;
            gulcoid = _gulcoid;
            */
        }

        //public long id { get; set; }
        public string gulcoid { get; set; }
        public string guaccountid { get; set; }
        public DateTime trandatetime { get; set; }
        public decimal credit { get; set; }
        public decimal debit { get; set; }
        //public decimal OpeningBalance { get; set; }
        public string description { get; set; }
        public string createuser { get; set; }
        public DateTime createdate { get; set; }
        public string source { get; set; }
        public string gurefid { get; set; }
        public string refid { get; set; }
        //public string 

    }
}
