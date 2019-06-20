using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public enum EstimateType
    {
        quick,
        basepackage,
        Alacarte
    }

    public class Estimate
    {
        private RestAPICall apicall;
        //private LedgerType _ledgerType;
        private string _entity;
        private string _applicationToken;
        private string uri_str;
        private string username;

        public Estimate( string entity, string ApplicationToken, string UserName)
        {
            //_ledgerType = ledgerType;
            _entity = entity;
            _applicationToken = ApplicationToken;
            apicall = new RestAPICall(ApplicationToken, UserName, entity);
            username = UserName;
            
        }


        public EstimateSingleResponcecs getPrice(string vcno,EstimateType estype)
        {
            switch (estype)
            {
                
                case EstimateType.basepackage:
                        return apicall.Get<EstimateSingleResponcecs>("account/renewcalculator/base_package/" + vcno);
                    break;
                case EstimateType.Alacarte:
                        return apicall.Get<EstimateSingleResponcecs>("account/renewcalculator/alacarte_package/" + vcno);
                    break;
                default:
                    return apicall.Get<EstimateSingleResponcecs>("account/renewcalculator/quick/" + vcno);
                    break;
            }
            
            //return 
        }

    }
}
