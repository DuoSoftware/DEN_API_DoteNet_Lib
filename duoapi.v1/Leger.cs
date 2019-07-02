using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public enum LedgerType{
        Customer,
        LCO
    }

    public class Ledger
    {
        private RestAPICall apicall;
        private LedgerType _ledgerType;
        private string _entity;
        private string _applicationToken;
        private string uri_str;
        private string username;


        public Ledger(LedgerType ledgerType,string entity,string ApplicationToken,string UserName)
        {
            _ledgerType = ledgerType;
            _entity = entity;
            _applicationToken = ApplicationToken;
            apicall = new RestAPICall(ApplicationToken, UserName, entity);
            username = UserName;
            switch (ledgerType)
            {
                case LedgerType.Customer:
                    uri_str = "account";
                    break;
                case LedgerType.LCO:
                    uri_str = "lco";
                    break;
            }
        }

        public decimal GetVauletBalance(string LedgerAccountID)
        {
            Results_LedgerBalance ds =apicall.Get<Results_LedgerBalance>("vault/"+ uri_str + "/balance/" + LedgerAccountID);
            if (ds.success)
            {
                return Convert.ToDecimal(ds.result);
            }
            else
            {
                throw new Exception(ds.message);
            }
            //return 0;
        }

        public DataTable GetLedger(string LedgerAccountID,int pageno)
        {
            return new DataTable();
        }

        public BlockTokenTicket BlockAmount(string LedgerAccountID, decimal EstimateAmount)
        {
            //{ "gulcoid":"M000100010000100001000000003","guaccountid":"","amount":100}
            return BlockAmount(LedgerAccountID, "",EstimateAmount);


        }

        public BlockTokenTicket BlockAmount(string LedgerAccountID, string GUAccountID,decimal EstimateAmount)
        {
            //{ "gulcoid":"M000100010000100001000000003","guaccountid":"","amount":100}
            POST_BlockLedger blockLedger = new POST_BlockLedger();
            blockLedger.gulcoid = LedgerAccountID;
            blockLedger.guaccountid = GUAccountID;
            blockLedger.amount = EstimateAmount;
            var result = apicall.POST<Results_BlockLedger>("vault/Block", blockLedger);
            if (result.success)
            {
                return result.result;
            }
            else
            {
                throw new Exception(result.message);
            }

        }

        public BlockTokenTicket BlockAmount(string LedgerAccountID, decimal EstimateAmount, List<SubLedgerAccount> SubLedgerAccounts)
        {
            throw new Exception("Not Implemented.");
        }

        public TranActionResponce SaveTransactions(BlockTokenTicket BlockToken, decimal ActualUtilizedAmount, List<LedgerTransactions> Transactions)
        {
            TranActionRequest tranReq = new TranActionRequest();
            tranReq.blockticket = BlockToken;
            tranReq.amount = ActualUtilizedAmount;
            tranReq.transactions = Transactions;
            //tranReq.GUVaultID=
            if (ActualUtilizedAmount < 0)
            {
                if (BlockToken.BlockID !=0)
                {
                    throw new Exception("You cant send credit to a block ticket Block Debit ID" + BlockToken.BlockID +" Amount "+BlockToken.Amount);
                }
            }
            decimal Amount=0;
            foreach(var item in Transactions)
            {
                //if()
                Amount += item.debit - item.credit;

            }
            if(Amount!= ActualUtilizedAmount)
            {
                throw new Exception("Actual Utilized Amount (" + ActualUtilizedAmount + ") Not Equals to Tranactions Sum Amount (" + BlockToken.Amount+")");

            }
            var result = apicall.POST<TranActionResponce>("vault/lco/save", tranReq);
            return result;
        }

        public TranActionResponce SaveTransactions(string GUVaultID, decimal TotalAmount, List<LedgerTransactions> Tranactions)
        {
            decimal Amount = 0;
            BlockTokenTicket bk = new BlockTokenTicket();
            bk.GUVaultID = GUVaultID;
            bk.BlockID = 0;
            bk.Amount = 0;
            foreach (var item in Tranactions)
            {
                //if()
                Amount += item.debit - item.credit;
                item.createuser = username;
                item.createdate = DateTime.Now;//.ToString("MM/dd");

            }
            //SaveTransactions(null,Amount, Tranactions);
            return  SaveTransactions(bk, Amount, Tranactions); 
        }

        public TranActionResponce SaveTransactions(string GUVaultID, LedgerTransactions Tranaction)
        {
            List<LedgerTransactions> Tranactions = new List<LedgerTransactions>();
            Tranactions.Add(Tranaction);
            decimal Amount = Tranaction.debit- Tranaction.credit;
            BlockTokenTicket bk = new BlockTokenTicket();
            bk.GUVaultID = GUVaultID;
            bk.BlockID = 0;
            bk.Amount = 0;
            return SaveTransactions(bk, Amount, Tranactions);
        }

        public LedgerTranactionResponce GetLedgerTraactions(string GUVaultID, int pageid) {
            var result = apicall.Get<LedgerTranactionResponce>("vault/lco/ledger/"+GUVaultID+"/"+pageid.ToString());
            return result;
        }

        public LedgerActiveBlocksResponce GetActiveBlocks(string GUVaultID)
        {
            var result = apicall.Get<LedgerActiveBlocksResponce>("vault/lco/activeblocks/" + GUVaultID);
            return result;
        }

        public bool RollBackTran(long id)
        {
            var result = apicall.Get<LedgerRollBackResponce>("vault/lco/rollback/" + id);
            return result.result;
        }
    }
}
