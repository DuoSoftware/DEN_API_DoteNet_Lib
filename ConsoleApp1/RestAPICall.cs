using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RestAPICall
    {
        public static string MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType, string Entity)
        {

            try
            {

                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                //WebRequest WR = WebRequest.Create(requestUrl);   
                request.Headers["entity"] = Entity;
                request.Headers["duoapikey"] = "bulk_estimation_api_0102";
                var sb = "";// JsonConvert.SerializeObject(JSONRequest); 
                request.Method = JSONmethod;
                if (JSONmethod == "POST")
                {
                    request.ContentType = JSONContentType; // "application/json";   

                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }


                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK) throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).", response.StatusCode,
                    response.StatusDescription));
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    string strsb = sr.ReadToEnd();
                    Console.WriteLine("End -> Request: " + DateTime.Now.ToString() + " - Remaining " + requestUrl);
                    Console.WriteLine("---------------------------------------------------");
                    return strsb;
                }
            }
            catch (Exception e)
            {
               throw e;
            }
        }
    }
}
