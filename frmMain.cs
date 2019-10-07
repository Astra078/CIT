/**
*** Author: Conor Lynch CIT185593
*** Date: 07/10/2019
*** IDE: Microsoft Visual Studio Enterprise 2017
*** IDE Version: 15.9.6
*** Software: Microsoft .NET Framework
*** Software Version: 4.7.02558
*** Platform: Microsoft Windows 8.1 64-bit
*** Platform Version: 6.3.9600 Build 9600
*** Project: Assessment 2
*** Objective: Creation of compound calculator built with nested classes and comparators and a Help file
***
*** Additional Notes: The nested classes are in CompoundInterest.cs
**/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assessment2NestedClassHelpFile
{
    public partial class frmMain : Form
    {
        CompoundInterest example;
        double loan, interest, compounds;
        int years;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dataRepayments.Rows.Clear();
            try
            {
                loan = Convert.ToDouble(txtLoan.Text);
                interest = Convert.ToDouble(txtInterest.Text)/100;
                years = Convert.ToInt32(txtLoanLength.Text);
            }
            catch
            {

            }

            double[,] array = new double[3, years];
            
            example = new CompoundInterest(loan, interest);
            for (int i = 0; i < years; i++)
            {
                array[2, i] = example.calcCompound();
                dataRepayments.Rows.Add(array[2, i]);
            }

        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
