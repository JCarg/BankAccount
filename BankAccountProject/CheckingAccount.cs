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
        private double checkingaccountbalance = 3500.00;
        private double totalcheckingdeposits;
        //private double availablebalance = 3500.00;
       
       //Properties
       public double CheckingBalance
       {
            get { return this.checkingaccountbalance; }
            set { this.checkingaccountbalance = value; }
       }
        public double TotalCheckingDeposit
        {
            get { return this.totalcheckingdeposits; }
            set { this.totalcheckingdeposits = value; }
        }

        //Constructors
        public CheckingAccount()
        {
            //this.totalcheckingdeposits +=
        }

        //Methods
        public override void Deposit()
        {
            base.Deposit();
            this.checkingaccountbalance += deposit;
            this.totalcheckingdeposits += deposit;
        }
        public override void Withdrawal()
        {
            base.Withdrawal();
            this.checkingaccountbalance -= withdrawal;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Checking Account Balance: " + CheckingBalance);
        }


    }
}
