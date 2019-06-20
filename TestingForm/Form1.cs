using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using duoapi.v1;

namespace TestingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Console.WriteLine("dddddd");
                Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);
                lblBalance.Text = ledger.GetVauletBalance(txtlco.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);
                //lblBalance.Text = 
                BlockTokenTicket Block = ledger.BlockAmount(txtlco.Text, Convert.ToDecimal(txtBlockAmout.Text));
                lblBlock.Text = Block.BlockID.ToString();
                lblappid.Text = Block.ApplicationID;
                lblBlockAmout.Text = Block.Amount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);

                BlockTokenTicket Block = ledger.BlockAmount(txtlco.Text, Convert.ToDecimal(txtBlockAmout.Text));
                var tranop = ledger.SaveTransactions(Block, Convert.ToDecimal(txtBlockAmout.Text), getDebitTrasaction());
                if (tranop.success)
                {
                    MessageBox.Show("Saved Sucessfully");
                }
                else
                {
                    MessageBox.Show(tranop.message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<LedgerTransactions> getDebitTrasaction()
        {
            List<LedgerTransactions> lst = new List<LedgerTransactions>();
            int NumberOfTrans = Convert.ToInt32(txtNumber.Text);
            decimal SlabAmount = Convert.ToDecimal(txtBlockAmout.Text) / NumberOfTrans;
            decimal Amount = Convert.ToDecimal(txtBlockAmout.Text);
            int r = 0;
            while (Amount > 0)
            {
                if ((Amount - SlabAmount) < 0)
                {
                    SlabAmount = Amount;
                }
                Amount -= SlabAmount;

                LedgerTransactions trns = new LedgerTransactions(txtlco.Text, "ALACARTE", "123", "455", "", "What :-" + r.ToString(), 0, SlabAmount);
                lst.Add(trns);
                //MessageBox.Show("");
                r++;
            }

            return lst;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);

                //BlockTokenTicket Block = ledger.BlockAmount(txtlco.Text, Convert.ToDecimal(txtBlockAmout.Text));
                LedgerTransactions trns = new LedgerTransactions(txtlco.Text, "ALACARTE", "123", "455", "", "What :-credit", Convert.ToDecimal(txtCredit.Text), 0);
                var tranop = ledger.SaveTransactions(txtlco.Text, trns);
                if (tranop.success)
                {
                    MessageBox.Show("Saved Sucessfully");
                }
                else
                {
                    MessageBox.Show(tranop.message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);

                //BlockTokenTicket Block = ledger.BlockAmount(txtlco.Text, Convert.ToDecimal(txtBlockAmout.Text));
                LedgerTransactions trns = new LedgerTransactions(txtlco.Text, "ALACARTE", "123", "455", "", "What :-debit singel", 0, Convert.ToDecimal(txtdebitAmount.Text));
                var tranop = ledger.SaveTransactions(txtlco.Text, trns);
                if (tranop.success)
                {
                    MessageBox.Show("Saved Sucessfully");
                }
                else
                {
                    MessageBox.Show(tranop.message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            Estimate es = new Estimate(cmboentity.Text, txtapiid.Text, txtusername.Text);
            EstimateSingleResponcecs res = es.getPrice(txtVCno.Text, EstimateType.quick);
            if (res.success)
            {
                lblB2B.Text = res.result.TotalB2BAmount.ToString();
                lblB2C.Text = res.result.TotalB2CAmount.ToString();


            }
            else
            {
                MessageBox.Show(res.message);
            }
            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string entity = ConfigurationSettings.AppSettings["entity"];
            string apikey = ConfigurationSettings.AppSettings["apikey"];
            string UserName = "Back End Process";
            Estimate es = new Estimate(cmboentity.Text, txtapiid.Text, txtusername.Text);
            EstimateSingleResponcecs res = es.getPrice(txtVCno.Text, EstimateType.quick);
            if (res.success)
            {
                try
                {
                    AccountWiseDebitsTrans acc = new AccountWiseDebitsTrans(entity, apikey, UserName, txtlco.Text, res.result.guaccountid, res.result.TotalB2BAmount);
                    Guid id = Guid.NewGuid();
                    string gurefid = id.ToString();
                    string refid = id.ToString();
                    acc.add("REW", gurefid, refid, "Acccount Renewed -" + txtVCno.Text, 0, res.result.TotalB2BAmount);
                    var respo = acc.Save();
                    if (respo.success)
                    {
                        MessageBox.Show("Saved with Number " + respo.result.TranID.ToString());
                    }

                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                MessageBox.Show(res.message);
            }
        }
        int pageid = 0;
        private void loadLedger()
        {
            Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);
            var r = ledger.GetLedgerTraactions(txtlco.Text, pageid);
            if (r.success)
            {
                dataGridView1.DataSource = r.result;
                //pageid++;
            }
            else
            {
                MessageBox.Show(r.message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pageid = 0;
            dataGridView1.DataSource = null;
            loadLedger();

        }
        //dataGridView1.



        private void button8_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);
            var r = ledger.GetActiveBlocks(txtlco.Text);
            if (r.success)
            {
                dataGridView2.DataSource = r.result;
            }
            else
            {
                MessageBox.Show(r.message);

            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
            pageid++;
            loadLedger();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pageid--;
            loadLedger();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger(LedgerType.LCO, cmboentity.Text, txtapiid.Text, txtusername.Text);
            List<LedgerActiveBlock> itmes =(List<LedgerActiveBlock>)dataGridView2.DataSource;
            foreach (var itm in itmes)
            {
                BlockTokenTicket Block = new BlockTokenTicket();
                Block.Amount = itm.BlockAmount;
                Block.BlockID = itm.ID;
                Block.GUVaultID = itm.GULCOID;

                var tranop = ledger.SaveTransactions(Block, 0, new List<LedgerTransactions>());
                if (tranop.success)
                {
                    MessageBox.Show("Cleared Sucessfully");
                }
                else
                {
                    MessageBox.Show(tranop.message);
                }
            }
        }
    }
}
