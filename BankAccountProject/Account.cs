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

        //Constructors
        public Account()
        {
            this.firstname = "Ebonezer";
            this.lastname = "Scrooge";
        }
        
        //Methods
        public virtual void DisplayInitialInfo()
        {
            Console.WriteLine("Welcome "+ Name+"!");
            Console.WriteLine("Account Number: " + AccountNumber);                    
        }        
    }
}
