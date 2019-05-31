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
            this.SuspendLayout();
            // 
            // txtlco
            // 
            this.txtlco.Location = new System.Drawing.Point(137, 154);
            this.txtlco.Name = "txtlco";
            this.txtlco.Size = new System.Drawing.Size(347, 22);
            this.txtlco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "gulcoid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
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
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(108, 193);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(53, 17);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "gulcoid";
            // 
            // txtBlockAmout
            // 
            this.txtBlockAmout.Location = new System.Drawing.Point(137, 223);
            this.txtBlockAmout.Name = "txtBlockAmout";
            this.txtBlockAmout.Size = new System.Drawing.Size(347, 22);
            this.txtBlockAmout.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bock Amout\'";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Block";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // lblappid
            // 
            this.lblappid.AutoSize = true;
            this.lblappid.Location = new System.Drawing.Point(134, 280);
            this.lblappid.Name = "lblappid";
            this.lblappid.Size = new System.Drawing.Size(53, 17);
            this.lblappid.TabIndex = 11;
            this.lblappid.Text = "gulcoid";
            // 
            // lblBlockAmout
            // 
            this.lblBlockAmout.AutoSize = true;
            this.lblBlockAmout.Location = new System.Drawing.Point(134, 297);
            this.lblBlockAmout.Name = "lblBlockAmout";
            this.lblBlockAmout.Size = new System.Drawing.Size(53, 17);
            this.lblBlockAmout.TabIndex = 11;
            this.lblBlockAmout.Text = "gulcoid";
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
            this.txtNumber.Location = new System.Drawing.Point(370, 344);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(115, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Number of fake Trasction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 741);
            this.Controls.Add(this.txtNumberOfTran);
            this.Controls.Add(this.lblBlockAmout);
            this.Controls.Add(this.lblappid);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmboentity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapiid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBlockAmout);
            this.Controls.Add(this.txtlco);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

