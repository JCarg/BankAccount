using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount:CheckingAccount
    {
        //Fields
        private double savingsaccountbalance = 250000.00;
        private double totalsavingsdeposits;
        private double totalsavingswithddrawals;
        //private double availablebalance = 3500.00;

        //Properties
        public double SavingsBalance
        {
            get { return this.savingsaccountbalance; }
            set { this.savingsaccountbalance = value; }
        }
        public double TotalSavingsDeposit
        {
            get { return this.totalsavingsdeposits; }
            set { this.totalsavingsdeposits = value; }
        }
        public double TotalSavingsWithdrawals
        {
            get { return this.totalsavingswithddrawals; }
            set { this.totalsavingswithddrawals = value; }
        }


        //Constructors
        public SavingsAccount()
        {
            //this.totalcheckingdeposits +=
        }

        //Methods
        public override void Deposit()
        {
            base.Deposit();
            this.savingsaccountbalance += deposit;
            this.totalsavingsdeposits += deposit;
        }
        public override void Withdrawal()
        {
            base.Withdrawal();
            this.savingsaccountbalance -= withdrawal;
            this.totalsavingswithddrawals -= withdrawal;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Savings Account Balance: " + SavingsBalance);
        }
        public void DisplaySavingsInfo()
        {
            Console.WriteLine("Savings Account Balance: " + SavingsBalance);
        }
    }
}
