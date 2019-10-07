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
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2NestedClassHelpFile
{
    class CompoundInterest
    {
        private double loan { get; set; }
        private double interest { get; set; }

        public CompoundInterest(double inLoan, double inInterest)
        {
            loan = inLoan;
            interest = inInterest;
        }

        public double calcCompound()
        {
            double compound = loan * interest + loan;
            loan = compound;
            return compound;
        }

        public double calcCompoundWithOutPrinc()
        {
            return 0;
        }

        private class interestRate
        {
            //P = A/(1+r/n)^nt
            
        }

        private class principal
        {
            //P = A/(1+r/n)^nt
            

            public double calcPrincipal()
            {
                return 0;
            }
        }

        private class timeFactor
        {
            //t = ln(A/P) / n[ln(1 + r/n)]
        }

    }
}
