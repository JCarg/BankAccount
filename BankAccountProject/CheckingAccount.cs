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
        private double checkingaccountbalance;
        private double totalcheckingdeposits;
        private double checkingdepositamount;
        private double checkingwithdrawalamount;
       
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
        public double CheckingDepositAmount
        {
            get { return this.checkingdepositamount; }
            set { this.checkingdepositamount = value; }
        }
        public double CheckingWithdrawalAmount
        {
            get { return this.checkingwithdrawalamount; }
            set { this.checkingwithdrawalamount = value; }
        }

        //Constructors
        public CheckingAccount()
        {
            this.checkingaccountbalance = 3500.00;
        }

        //Methods
        public void CheckingDeposit()
        {
            this.checkingaccountbalance += checkingdepositamount;
            this.totalcheckingdeposits += checkingdepositamount;
        }
        public void CheckingWithdrawal()
        {
            this.checkingaccountbalance -= checkingwithdrawalamount;
        }

        public override void DisplayInitialInfo()
        {
            base.DisplayInitialInfo();
            Console.WriteLine("Checking Account Balance: " +"$"+ checkingaccountbalance);
        }
        public void DisplayCheckingsInfo()
        {
            Console.WriteLine("Checking Account Balance: " + "$" + checkingaccountbalance);
        }


    }
}
