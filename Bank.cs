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
*** Objective: Creation of pseudo bank built with nested classes.
**/

using System.Collections.Generic;
using System.Linq;

namespace Assessment2NestedClassHelpFile
{
    class Bank
    {
        public List<Account> accounts = new List<Account>();
        private double totalCash;
        public string name { get; }

        public Bank(string inName)
        {
            name = inName;
            totalCash = 0;
        }

        public int getAccounts()
        {
            return accounts.Count() - 1;//Arrays start at Zero
        }


        public void newAccount(string inName)
        {
            accounts.Add(new Account(inName, accounts.Count(), this));//Reference this to the account constructor to avoid extra typing
        }

        internal class Account
        {
            public string owner { get; set; }
            Bank bank;//Set account to only work with a single bank
            private int accountNo { get;}
            private double money { get; set; }

            public Account(string inOwner, int inAccountNo, Bank inBank)
            {
                owner = inOwner;
                accountNo = inAccountNo;
                bank = inBank;
            }

            public void deposit(double inDeposit)
            {
                bank.totalCash = bank.totalCash + inDeposit;
                money = money + inDeposit;
            }

            public bool withdraw(double inRequest)
            {
                if(inRequest <= money && inRequest <= bank.totalCash)
                {
                    money = money - inRequest;
                    bank.totalCash = bank.totalCash - inRequest;
                    return true;
                }
                else
                    return false;

            }

            public double showBalance()
            {
                return money;
            }
        }
    }
}
