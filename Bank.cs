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
*** Objective: Creation of pseudo bank built with nested classes and comparators.
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2NestedClassHelpFile
{
    class Bank
    {
        private List<Account> accounts = new List<Account>();
        private double totalCash;
        public string name { get; }

        public Bank(string inName)
        {
            name = inName;
            totalCash = 0;
        }



        public void newAccount(string inName)
        {
            accounts.Add(new Account(inName, accounts.Count()));
        }

        private class Account
        {
            public string owner { get; set; }
            private int accountNo { get; set; }
            private double money;

            public Account(string inOwner, int inAccountNo)
            {
                owner = inOwner;
                accountNo = inAccountNo;
            }

            public bool withdraw(double inRequest, Bank bank)
            {
                if(inRequest < money && inRequest < bank.totalCash)
                {
                    money = money - inRequest;
                    bank.totalCash = bank.totalCash - inRequest;
                    return true;
                }
                else
                    return false;

            }
        }
    }
}
