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
        private double savingsaccountbalance;
        private double totalsavingsdeposits;
        private double savingsdepositamount;
        private double savingswithdrawalamount;

        //Properties
        public double SavingsBalance
        {
            get { return this.savingsaccountbalance; }
            set { this.savingsaccountbalance = value; }
        }
        public double TotalSavingsDeposita
        {
            get { return this.totalsavingsdeposits; }
            set { this.totalsavingsdeposits = value; }
        }
        public double SavingsDepositAmount
        {
            get { return this.savingsdepositamount; }
            set { this.savingsdepositamount = value; }
        }
        public double SavingsWithdrawalAmount
        {
            get { return this.savingswithdrawalamount; }
            set { this.savingswithdrawalamount = value; }
        }


        //Constructors
        public SavingsAccount():base()
        {
            this.savingsaccountbalance = 25000.00;
        }

        //Methods
        public void SavingsDeposit()
        {
            this.savingsaccountbalance += savingsdepositamount;
            this.totalsavingsdeposits += savingsdepositamount;
        }
        public void SavingsWithdrawal()
        {
            this.savingsaccountbalance -= savingswithdrawalamount;
        }

        public override void DisplayInitialInfo()
        {
            base.DisplayInitialInfo();
            Console.WriteLine("Savings Account Balance: " +"$"+ SavingsBalance);
        }
        public void DisplaySavingsInfo()
        {
            Console.WriteLine("Savings Account Balance: " + SavingsBalance);
        }
    }
}
