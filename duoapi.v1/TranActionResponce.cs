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
        public List<LedgerTransactions>  result { get; set; }
        /*public BlockTokenTicket blockticket { get; set; }
        public decimal amount { get; set; }
        public List<LedgerTransactions> transactions { get; set; }*/

    }

    public class TranActionRequest
    {
        public BlockTokenTicket blockticket { get; set; }
        public decimal amount { get; set; }
        public List<LedgerTransactions> transactions { get; set; }

    }
}
