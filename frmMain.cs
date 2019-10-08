/**
*** Author: Conor Lynch CIT185593
*** Date: 08/10/2019
*** IDE: Microsoft Visual Studio Enterprise 2017
*** IDE Version: 15.9.6
*** Software: Microsoft .NET Framework
*** Software Version: 4.7.02558
*** Platform: Microsoft Windows 8.1 64-bit
*** Platform Version: 6.3.9600 Build 9600
*** Project: Assessment 2
*** Objective: Creation of a vehicle application with nested classes, comparators and a Help file
***
*** Additional Notes: The nested classes are in Banks.cs
**/


using System;
using System.Windows.Forms;


namespace Assessment2NestedClassHelpFile
{
    public partial class frmMain : Form
    {
        Bank bank = new Bank("Big Bank");
        int accountNum = -1;
        bool logged = false;
        WebBrowser browser;

        public frmMain()
        {
            InitializeComponent();
            bank.newAccount("Conor Lynch");
            bank.accounts[0].deposit(200);//Some starting fund
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void btnLogon_Click(object sender, EventArgs e)
        {
            if (!logged)
            {
                try
                {
                    accountNum = Convert.ToInt32(txtAccountNo.Text);
                }
                catch
                {
                    accountNum = -1;
                    lblBankName.Text = "That account does\nnot exist";
                }
                if (accountNum <= bank.getAccounts() && accountNum > -1)//Checks to see if the account is there
                {
                    logged = true;
                    lblBankName.Text = "Welcome to " + bank.name + "\n" + bank.accounts[accountNum].owner;
                    txtAccountNo.Enabled = false;
                    lblBalance.Visible = true;
                    txtBalance.Visible = true;
                    lblValue.Visible = true;
                    txtValue.Visible = true;
                    btnDeposit.Visible = true;
                    btnWithdraw.Visible = true;
                    btnLogon.Text = "Logoff";
                    mnuFileLogout.Enabled = true;
                    updateBalance(accountNum);
                }
                else
                    lblBankName.Text = "That account does\nnot exist";
            }
            else
                logOff();
        }

        public void logOff()
        {//reverst to accessable GUI contents
            logged = false;
            lblBankName.Text = "The Big Bank";
            accountNum = -1;
            txtAccountNo.Enabled = true;
            lblBalance.Visible = false;
            txtBalance.Visible = false;
            lblValue.Visible = false;
            txtValue.Visible = false;
            btnDeposit.Visible = false;
            btnWithdraw.Visible = false;
            btnLogon.Text = "Logon";
            txtAccountNo.Text = "";
            txtBalance.Text = "";
            mnuFileLogout.Enabled = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = Convert.ToInt32(txtValue.Text);
                lblBankName.Text = "Thanks for your deposit";
                bank.accounts[accountNum].deposit(amount);
                updateBalance(accountNum);
                txtValue.Text = 0 + "";
            }
            catch
            {
                lblBankName.Text = "Please insert a numeric number";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = Convert.ToInt32(txtValue.Text);
                lblBankName.Text = "Thanks for your service";
                if (bank.accounts[accountNum].withdraw(amount))
                {
                    lblBankName.Text = "Thanks for your service";
                    updateBalance(accountNum);
                    txtValue.Text = 0 + "";
                }
                else
                {
                    lblBankName.Text = "Insufficient Funds";
                    txtValue.Text = 0 + "";
                }
                
            }
            catch
            {
                lblBankName.Text = "Please insert a numeric number";
            }
        }

        private void updateBalance(int inAccount)
        {
            txtBalance.Text = bank.accounts[accountNum].showBalance()+"";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOff();
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            //Open the help file
            System.Diagnostics.Process.Start("The Big Bank User Guide.pdf");
        }
    }
}
