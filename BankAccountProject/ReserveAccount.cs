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
        private double reservewithddrawalamount;
        private double reservedepositamount;

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
        public double ReserveWithdrawalAmount
        {
            get { return this.reservewithddrawalamount; }
            set { this.reservewithddrawalamount = value; }
        }
        public double ReserveDepositAmount
        {
            get { return this.reservedepositamount; }
            set { this.reservedepositamount = value; }
        }



        //Constructors
        public ReserveAccount()
        {
            //this.totalcheckingdeposits +=
        }

        //Methods
        public void ReserveDeposit()
        {
            this.reserveaccountbalance += reservedepositamount;
            this.totalreservedeposits += reservedepositamount;
        }
        public void ReserveWithdrawal()
        {
            this.reserveaccountbalance -= reservewithddrawalamount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Reserve Account Balance: " +"$"+ ReserveBalance);
        }
        public void DisplayReserveInfo()
        {
            Console.WriteLine("Savings Account Balance: " + ReserveBalance);
        }

    }
}
