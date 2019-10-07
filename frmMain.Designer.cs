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
            this.lblMorRate = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblRepayRate = new System.Windows.Forms.Label();
            this.lblRepayDate = new System.Windows.Forms.Label();
            this.cmbMorRate = new System.Windows.Forms.ComboBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.cmbRepayRate = new System.Windows.Forms.ComboBox();
            this.dateRepayDate = new System.Windows.Forms.DateTimePicker();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataRepayments = new System.Windows.Forms.DataGridView();
            this.VarRepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principleRepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRepayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMorRate
            // 
            this.lblMorRate.AutoSize = true;
            this.lblMorRate.Location = new System.Drawing.Point(12, 32);
            this.lblMorRate.Name = "lblMorRate";
            this.lblMorRate.Size = new System.Drawing.Size(138, 17);
            this.lblMorRate.TabIndex = 1;
            this.lblMorRate.Text = "Morgage Rate Type:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(12, 63);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(96, 17);
            this.lblLoanAmount.TabIndex = 2;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(11, 92);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(93, 17);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblRepayRate
            // 
            this.lblRepayRate.AutoSize = true;
            this.lblRepayRate.Location = new System.Drawing.Point(11, 121);
            this.lblRepayRate.Name = "lblRepayRate";
            this.lblRepayRate.Size = new System.Drawing.Size(118, 17);
            this.lblRepayRate.TabIndex = 4;
            this.lblRepayRate.Text = "Repayment Rate:";
            // 
            // lblRepayDate
            // 
            this.lblRepayDate.AutoSize = true;
            this.lblRepayDate.Location = new System.Drawing.Point(11, 154);
            this.lblRepayDate.Name = "lblRepayDate";
            this.lblRepayDate.Size = new System.Drawing.Size(118, 17);
            this.lblRepayDate.TabIndex = 5;
            this.lblRepayDate.Text = "Repayment Date:";
            // 
            // cmbMorRate
            // 
            this.cmbMorRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorRate.Items.AddRange(new object[] {
            "Variable interest rate",
            "fixed interest rate",
            "split interest rate"});
            this.cmbMorRate.Location = new System.Drawing.Point(157, 29);
            this.cmbMorRate.Name = "cmbMorRate";
            this.cmbMorRate.Size = new System.Drawing.Size(233, 24);
            this.cmbMorRate.TabIndex = 6;
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(157, 60);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(233, 22);
            this.txtLoan.TabIndex = 7;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(157, 89);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(233, 22);
            this.txtInterest.TabIndex = 8;
            // 
            // cmbRepayRate
            // 
            this.cmbRepayRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepayRate.FormattingEnabled = true;
            this.cmbRepayRate.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Quarterly",
            "Semi-Anually",
            "Yearly"});
            this.cmbRepayRate.Location = new System.Drawing.Point(157, 118);
            this.cmbRepayRate.Name = "cmbRepayRate";
            this.cmbRepayRate.Size = new System.Drawing.Size(233, 24);
            this.cmbRepayRate.TabIndex = 9;
            // 
            // dateRepayDate
            // 
            this.dateRepayDate.Location = new System.Drawing.Point(157, 149);
            this.dateRepayDate.Name = "dateRepayDate";
            this.dateRepayDate.Size = new System.Drawing.Size(233, 22);
            this.dateRepayDate.TabIndex = 10;
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
            this.btnCalculate.Location = new System.Drawing.Point(157, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // dataRepayments
            // 
            this.dataRepayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRepayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarRepayment,
            this.principleRepayment,
            this.interestRepayments});
            this.dataRepayments.Location = new System.Drawing.Point(0, 228);
            this.dataRepayments.Name = "dataRepayments";
            this.dataRepayments.ReadOnly = true;
            this.dataRepayments.RowTemplate.Height = 24;
            this.dataRepayments.Size = new System.Drawing.Size(583, 220);
            this.dataRepayments.TabIndex = 19;
            // 
            // VarRepayment
            // 
            this.VarRepayment.HeaderText = "Weekly Repayment Dates";
            this.VarRepayment.Name = "VarRepayment";
            this.VarRepayment.ReadOnly = true;
            this.VarRepayment.Width = 200;
            // 
            // principleRepayment
            // 
            this.principleRepayment.HeaderText = "Principle Repayment";
            this.principleRepayment.Name = "principleRepayment";
            this.principleRepayment.ReadOnly = true;
            this.principleRepayment.Width = 170;
            // 
            // interestRepayments
            // 
            this.interestRepayments.HeaderText = "Interest Repayments";
            this.interestRepayments.Name = "interestRepayments";
            this.interestRepayments.ReadOnly = true;
            this.interestRepayments.Width = 170;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.dataRepayments);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dateRepayDate);
            this.Controls.Add(this.cmbRepayRate);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.cmbMorRate);
            this.Controls.Add(this.lblRepayDate);
            this.Controls.Add(this.lblRepayRate);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblMorRate);
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
        private System.Windows.Forms.Label lblMorRate;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblRepayRate;
        private System.Windows.Forms.Label lblRepayDate;
        private System.Windows.Forms.ComboBox cmbMorRate;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.ComboBox cmbRepayRate;
        private System.Windows.Forms.DateTimePicker dateRepayDate;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dataRepayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarRepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn principleRepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRepayments;
    }
}

