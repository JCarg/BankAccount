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
        private double reserveaccountbalance;
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
        public ReserveAccount():base()
        {
            this.reserveaccountbalance = 320123.00;
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

        public override void DisplayInitialInfo()
        {
            base.DisplayInitialInfo();
            Console.WriteLine("Reserve Account Balance: " +"$"+ ReserveBalance);
        }
        public void DisplayReserveInfo()
        {
            Console.WriteLine("Reserve Account Balance: " +"$"+ ReserveBalance);
        }

    }
}
