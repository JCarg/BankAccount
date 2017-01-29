using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
     class Account
    {
        //Fields
        private string firstname;
        private string lastname;
        private double accountnumber=312613;
        protected double withdrawal;
        protected double deposit;

        //properties
        public string Name
        {
            get { return this.firstname +" "+ this.lastname; }
            set { this.lastname = value; }
        }
        public double AccountNumber
        {
            get { return this.accountnumber; }
            set { this.accountnumber = value; }
        }
        public double DepositAmount
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        //Constructors
        public Account()
        {
            this.firstname = "Ebonezer";
            this.lastname = "Scrooge";
        }
        public Account(string firstname)
        {
            
        }
        //Methods
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Welcome "+ Name+"!");
            Console.WriteLine("Account Number: " + AccountNumber);     
                     
        }
        public void GetAccountNumber()
        {
            Random rand = new Random();
            AccountNumber=rand.Next(369000, 370000);    
        }
        public virtual void Deposit()
        {

        }
        public virtual void Withdrawal()
        {

        }
        
    }
}
