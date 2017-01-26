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
        private CheckingAccount()
        {
            this.totalcheckingdeposits=
        }
        
        //Methods
        public virtual static DepositingFunds()
        {
            double Deposit = int.Parse(Console.ReadLine());
            this.checkingaccountbal
        }


    }
}
