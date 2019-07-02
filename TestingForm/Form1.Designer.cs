namespace TestingForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtlco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapiid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboentity = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBlockAmout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBlock = new System.Windows.Forms.Label();
            this.lblappid = new System.Windows.Forms.Label();
            this.lblBlockAmout = new System.Windows.Forms.Label();
            this.txtNumberOfTran = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtdebitAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtVCno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblB2C = new System.Windows.Forms.Label();
            this.lblB2B = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlco
            // 
            this.txtlco.Location = new System.Drawing.Point(137, 109);
            this.txtlco.Name = "txtlco";
            this.txtlco.Size = new System.Drawing.Size(347, 22);
            this.txtlco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "gulcoid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "apiid";
            // 
            // txtapiid
            // 
            this.txtapiid.Location = new System.Drawing.Point(137, 12);
            this.txtapiid.Name = "txtapiid";
            this.txtapiid.Size = new System.Drawing.Size(347, 22);
            this.txtapiid.TabIndex = 3;
            this.txtapiid.Text = "test-api-key-101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "userid";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(137, 40);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(347, 22);
            this.txtusername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "entity";
            // 
            // cmboentity
            // 
            this.cmboentity.Enabled = false;
            this.cmboentity.FormattingEnabled = true;
            this.cmboentity.Items.AddRange(new object[] {
            "dendb",
            "denkk",
            "82-geminicable",
            "geminicable",
            "crystalvision",
            "denambey",
            "enjoy"});
            this.cmboentity.Location = new System.Drawing.Point(138, 68);
            this.cmboentity.Name = "cmboentity";
            this.cmboentity.Size = new System.Drawing.Size(216, 24);
            this.cmboentity.TabIndex = 9;
            this.cmboentity.Text = "82-dendb";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(148, 144);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(206, 58);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance";
            // 
            // txtBlockAmout
            // 
            this.txtBlockAmout.Location = new System.Drawing.Point(140, 342);
            this.txtBlockAmout.Name = "txtBlockAmout";
            this.txtBlockAmout.Size = new System.Drawing.Size(112, 22);
            this.txtBlockAmout.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bock Amout\'";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Block";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(134, 263);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(53, 17);
            this.lblBlock.TabIndex = 11;
            this.lblBlock.Text = "gulcoid";
            this.lblBlock.Visible = false;
            // 
            // lblappid
            // 
            this.lblappid.AutoSize = true;
            this.lblappid.Location = new System.Drawing.Point(134, 280);
            this.lblappid.Name = "lblappid";
            this.lblappid.Size = new System.Drawing.Size(53, 17);
            this.lblappid.TabIndex = 11;
            this.lblappid.Text = "gulcoid";
            this.lblappid.Visible = false;
            // 
            // lblBlockAmout
            // 
            this.lblBlockAmout.AutoSize = true;
            this.lblBlockAmout.Location = new System.Drawing.Point(134, 297);
            this.lblBlockAmout.Name = "lblBlockAmout";
            this.lblBlockAmout.Size = new System.Drawing.Size(53, 17);
            this.lblBlockAmout.TabIndex = 11;
            this.lblBlockAmout.Text = "gulcoid";
            this.lblBlockAmout.Visible = false;
            // 
            // txtNumberOfTran
            // 
            this.txtNumberOfTran.Location = new System.Drawing.Point(491, 342);
            this.txtNumberOfTran.Name = "txtNumberOfTran";
            this.txtNumberOfTran.Size = new System.Drawing.Size(294, 23);
            this.txtNumberOfTran.TabIndex = 12;
            this.txtNumberOfTran.Text = "Save Debit Transaction";
            this.txtNumberOfTran.UseVisualStyleBackColor = true;
            this.txtNumberOfTran.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(432, 344);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(53, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Number of fake Trasction";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(370, 373);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(115, 22);
            this.txtCredit.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Credit Amout";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save Credit Transaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtdebitAmount
            // 
            this.txtdebitAmount.Location = new System.Drawing.Point(370, 402);
            this.txtdebitAmount.Name = "txtdebitAmount";
            this.txtdebitAmount.Size = new System.Drawing.Size(115, 22);
            this.txtdebitAmount.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Credit without block Amout";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Save debit Transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtVCno
            // 
            this.txtVCno.Location = new System.Drawing.Point(905, 14);
            this.txtVCno.Name = "txtVCno";
            this.txtVCno.Size = new System.Drawing.Size(347, 22);
            this.txtVCno.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(810, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Estimate";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1259, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Get Estimate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblB2C
            // 
            this.lblB2C.AutoSize = true;
            this.lblB2C.Location = new System.Drawing.Point(1204, 45);
            this.lblB2C.Name = "lblB2C";
            this.lblB2C.Size = new System.Drawing.Size(48, 17);
            this.lblB2C.TabIndex = 13;
            this.lblB2C.Text = "lblB2C";
            // 
            // lblB2B
            // 
            this.lblB2B.AutoSize = true;
            this.lblB2B.Location = new System.Drawing.Point(1204, 75);
            this.lblB2B.Name = "lblB2B";
            this.lblB2B.Size = new System.Drawing.Size(54, 17);
            this.lblB2B.TabIndex = 14;
            this.lblB2B.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1111, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "B2C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2175, -139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1111, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "B2B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2082, -137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "gulcoid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3152, -325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "label11";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1259, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Auto Renew";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1360, 288);
            this.dataGridView1.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1259, 403);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Load Ledger";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(65, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(561, 123);
            this.dataGridView2.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(512, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 58);
            this.button8.TabIndex = 2;
            this.button8.Text = "Get Active Blocks";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1097, 403);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Next >>";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(978, 403);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "<< Back";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(642, 205);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 123);
            this.button11.TabIndex = 2;
            this.button11.Text = "Clear";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 741);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblB2B);
            this.Controls.Add(this.lblB2C);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNumberOfTran);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblBlockAmout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblappid);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmboentity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapiid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdebitAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtVCno);
            this.Controls.Add(this.txtBlockAmout);
            this.Controls.Add(this.txtlco);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapiid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboentity;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBlockAmout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Label lblappid;
        private System.Windows.Forms.Label lblBlockAmout;
        private System.Windows.Forms.Button txtNumberOfTran;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtdebitAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtVCno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblB2C;
        private System.Windows.Forms.Label lblB2B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

