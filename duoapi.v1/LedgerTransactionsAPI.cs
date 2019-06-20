using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
 
    public class LedgerTransactionsAPI
    {
        

        public long id { get; set; }
        public string gulcoid { get; set; }
        public string guaccountid { get; set; }
        public apidatetime trandatetime { get; set; }
        public decimal credit { get; set; }
        public decimal debit { get; set; }
        public decimal OpeningBalance { get; set; }
        //public decimal OpeningBalance { get; set; }
        public string description { get; set; }
        public string createuser { get; set; }
        public apidatetime createdate { get; set; }
        public string source { get; set; }
        public string gurefid { get; set; }
        public string refid { get; set; }
        public string ledgerid { get; set; }
        //public string 

    }
}
