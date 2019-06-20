using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public class EstimateHeader {
        public string guaccountid { get; set; }
        public string VCNO { get; set; }
        public string STBNO  { get; set; }
        public string LCOCode { get; set; }
        public decimal TotalB2BAmount { get; set; }
        public decimal TotalB2CAmount { get; set; }
        
    }
    public class EstimateSingleResponcecs
    {
        public bool success { get; set; }
        public EstimateHeader result { get; set; }
        public string message { get; set; }
    }


    public class EstimateResponcecs
    {
        public bool success { get; set; }
        public List<EstimateHeader> result { get; set; }
        public string message { get; set; }
    }
}
