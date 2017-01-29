using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class ReserveAccount:SavingsAccount
    {
        //Fields
        private double reserveaccountbalance = 320123.00;
        private double totalreservedeposits;
        private double totalreservewithddrawals;
        //private double availablebalance = 3500.00;

        //Properties
        public double ReserveBalance
        {
            get { return this.reserveaccountbalance; }
            set { this.reserveaccountbalance = value; }
        }
        public double TotalReserveDeposit
        {
            get { return this.totalreservedeposits; }
            set { this.totalreservedeposits = value; }
        }
        public double TotalReserveWithdrawals
        {
            get { return this.totalreservewithddrawals; }
            set { this.totalreservewithddrawals = value; }
        }


        //Constructors
        public ReserveAccount()
        {
            //this.totalcheckingdeposits +=
        }

        //Methods
        public override void Deposit()
        {
            base.Deposit();
            this.reserveaccountbalance += deposit;
            this.totalreservedeposits += deposit;
        }
        public override void Withdrawal()
        {
            base.Withdrawal();
            this.reserveaccountbalance -= withdrawal;
            this.totalreservewithddrawals -= withdrawal;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Reserve Account Balance: " + ReserveBalance);
        }
        public void DisplayReserveInfo()
        {
            Console.WriteLine("Savings Account Balance: " + ReserveBalance);
        }

    }
}
