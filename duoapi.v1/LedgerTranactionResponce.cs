using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public class LedgerTranactionResponce
    {
        public bool success { get; set; }
        public List<LedgerTransactionsAPI> result { get; set; }
        public string message { get; set; }
    }
}
