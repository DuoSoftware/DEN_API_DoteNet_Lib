using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public class TranActionResponce
    {
        public bool success { get; set; }
        public TranActionResults result { get; set; }
        public string message { get; set; }
        /*public BlockTokenTicket blockticket { get; set; }
        public decimal amount { get; set; }
        public List<LedgerTransactions> transactions { get; set; }*/

    }

    public class TranActionResults 
    {
        public Int64 TranID { get; set; }
        public List<LedgerTransactions> items { get; set; }

    }

    public class TranActionRequest
    {
        public BlockTokenTicket blockticket { get; set; }
        public string GUVaultID { get; set; }
        public decimal amount { get; set; }
        public List<LedgerTransactions> transactions { get; set; }
        

    }
}
