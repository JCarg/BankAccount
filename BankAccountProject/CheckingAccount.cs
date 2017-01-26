using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount:Account
    {
        //Fields
        private double checkingbalance = 3500.00;
        private double totalcheckingdeposits;

       //Properties
       public double CheckingBalance
       {
            get { return this.checkingbalance; }
            set { this.checkingbalance = value; }
       }
        public double TotalCheckingDeposit
        {
            get { return this.totalcheckingdeposits; }
            set { this.totalcheckingdeposits = value; }
        }
        
        //Methods


    }
}
