using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public class LedgerActiveBlock
    {
        public int ID { get; set; }
        public string ApplicationID { get; set; }
        public string GULCOID { get; set; }
        public string GUAccountID { get; set; }
        public decimal BlockAmount { get; set; }
        public apidatetime Createdate { get; set; }
        public string User { get; set; }
    }
    public class LedgerActiveBlocksResponce
    {
        public bool success { get; set; }
        public List<LedgerActiveBlock> result { get; set; }
        public string message { get; set; }
    }
}
