namespace Assessment2NestedClassHelpFile
{
    partial class frmMain
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
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoanLength = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataRepayments = new System.Windows.Forms.DataGridView();
            this.VarRepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principleRepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalInterestPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoanLength = new System.Windows.Forms.TextBox();
            this.txtRepayment = new System.Windows.Forms.TextBox();
            this.lblRepayment = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(12, 40);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(96, 17);
            this.lblLoanAmount.TabIndex = 2;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(11, 69);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(93, 17);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblLoanLength
            // 
            this.lblLoanLength.AutoSize = true;
            this.lblLoanLength.Location = new System.Drawing.Point(12, 97);
            this.lblLoanLength.Name = "lblLoanLength";
            this.lblLoanLength.Size = new System.Drawing.Size(136, 17);
            this.lblLoanLength.TabIndex = 5;
            this.lblLoanLength.Text = "Loan Length Yearly:";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(189, 37);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(233, 22);
            this.txtLoan.TabIndex = 7;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(189, 66);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(233, 22);
            this.txtInterest.TabIndex = 8;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(586, 28);
            this.mnuStrip.TabIndex = 12;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(108, 26);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp});
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(62, 24);
            this.mnuAbout.Text = "About";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(143, 26);
            this.mnuAboutHelp.Text = "Help File";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(261, 122);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dataRepayments
            // 
            this.dataRepayments.AllowUserToAddRows = false;
            this.dataRepayments.AllowUserToDeleteRows = false;
            this.dataRepayments.AllowUserToResizeColumns = false;
            this.dataRepayments.AllowUserToResizeRows = false;
            this.dataRepayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRepayments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataRepayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRepayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarRepayment,
            this.principleRepayment,
            this.totalInterestPaid});
            this.dataRepayments.Location = new System.Drawing.Point(0, 185);
            this.dataRepayments.Name = "dataRepayments";
            this.dataRepayments.ReadOnly = true;
            this.dataRepayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataRepayments.RowTemplate.Height = 24;
            this.dataRepayments.Size = new System.Drawing.Size(583, 263);
            this.dataRepayments.TabIndex = 19;
            // 
            // VarRepayment
            // 
            this.VarRepayment.FillWeight = 111.1111F;
            this.VarRepayment.HeaderText = "Weekly Repayment Dates";
            this.VarRepayment.Name = "VarRepayment";
            this.VarRepayment.ReadOnly = true;
            this.VarRepayment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // principleRepayment
            // 
            this.principleRepayment.FillWeight = 95.34039F;
            this.principleRepayment.HeaderText = "Principle Repayment";
            this.principleRepayment.Name = "principleRepayment";
            this.principleRepayment.ReadOnly = true;
            this.principleRepayment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalInterestPaid
            // 
            this.totalInterestPaid.FillWeight = 93.54849F;
            this.totalInterestPaid.HeaderText = "Total Interest Paid";
            this.totalInterestPaid.Name = "totalInterestPaid";
            this.totalInterestPaid.ReadOnly = true;
            this.totalInterestPaid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtLoanLength
            // 
            this.txtLoanLength.Location = new System.Drawing.Point(189, 94);
            this.txtLoanLength.Name = "txtLoanLength";
            this.txtLoanLength.Size = new System.Drawing.Size(233, 22);
            this.txtLoanLength.TabIndex = 20;
            // 
            // txtRepayment
            // 
            this.txtRepayment.Enabled = false;
            this.txtRepayment.Location = new System.Drawing.Point(189, 151);
            this.txtRepayment.Name = "txtRepayment";
            this.txtRepayment.Size = new System.Drawing.Size(233, 22);
            this.txtRepayment.TabIndex = 21;
            // 
            // lblRepayment
            // 
            this.lblRepayment.AutoSize = true;
            this.lblRepayment.Location = new System.Drawing.Point(12, 154);
            this.lblRepayment.Name = "lblRepayment";
            this.lblRepayment.Size = new System.Drawing.Size(153, 17);
            this.lblRepayment.TabIndex = 22;
            this.lblRepayment.Text = "Required Repayments:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.lblRepayment);
            this.Controls.Add(this.txtRepayment);
            this.Controls.Add(this.txtLoanLength);
            this.Controls.Add(this.dataRepayments);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblLoanLength);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMain";
            this.Text = "Compound Interest Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblLoanLength;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dataRepayments;
        private System.Windows.Forms.TextBox txtLoanLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarRepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn principleRepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalInterestPaid;
        private System.Windows.Forms.TextBox txtRepayment;
        private System.Windows.Forms.Label lblRepayment;
    }
}

