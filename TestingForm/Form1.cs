using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                BlockTokenTicket Block=  ledger.BlockAmount(txtlco.Text,Convert.ToDecimal(txtBlockAmout.Text));
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
                ledger.SaveTransactions(Block, Convert.ToDecimal(txtBlockAmout.Text), getDebitTrasaction());
                MessageBox.Show("Saved Sucessfully");

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
                if ((Amount - SlabAmount)<0)
                {
                    SlabAmount = Amount;
                }
                Amount -= SlabAmount;
                
                LedgerTransactions trns = new LedgerTransactions(txtlco.Text, "ALACARTE", "123", "455", "", "What :-"+r.ToString(), 0, SlabAmount);
                lst.Add(trns);
                //MessageBox.Show("");
                r++;
            }

            return lst;
        }
    }
}
