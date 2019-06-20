using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duoapi.v1
{
    public class AccountWiseDebitsTrans
    {
        private Ledger ledg;
        private List<LedgerTransactions> Trans = new List<LedgerTransactions>();
        private BlockTokenTicket Block;
        private string gulcoid;
        private string guaccountid;
        private string username;
        private decimal amount=0;

        public AccountWiseDebitsTrans( string entity, string ApplicationToken, string UserName,string _gulcoid, string _guaccountid,decimal BlockAmout)
        {
            ledg = new Ledger(LedgerType.LCO, entity, ApplicationToken, UserName);
            Block = ledg.BlockAmount(_gulcoid, BlockAmout);
            gulcoid = _gulcoid;
            guaccountid = _guaccountid;
            username = UserName;


        }

        public void add( string _source, string _gurefid, string _refid, string _description, decimal _credit, decimal _debit) {

            LedgerTransactions tranItem = new LedgerTransactions(gulcoid, _source, _gurefid, _refid, guaccountid, _description, _credit, _debit);
            tranItem.createuser = username;
            if (Block.Amount > (amount + _debit))
            {
                throw new Exception("Amount Has Exceeded could not add no more");
                return;
            }
            amount += _debit;
            Trans.Add(tranItem);
        }

        public TranActionResponce Save() {

            var tranop = ledg.SaveTransactions(Block, amount, Trans);
            if (tranop.success)
            {
                return tranop;
            }
            else
            {
                throw new Exception(tranop.message);
            }
        }


    }
}
