using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {

            ReserveAccount Client = new ReserveAccount();

        //          Main User Interface
            Client.DisplayInitialInfo();
        MainMenu:           
            Console.WriteLine("Please select the account you would like to access.");
            Console.WriteLine("Type number of selection:");
            Console.WriteLine("1. Checkings");
            Console.WriteLine("2. Savings");
            Console.WriteLine("3. Reserve");
            string accountselection = Console.ReadLine();

            if (accountselection == "1")
            {
                Console.WriteLine("Would you like to make a withdrawal or deposit?");
                Console.WriteLine("Type W for withdrawal or D for deposit:");
            CheckingsMenu:
                string accountaltertype = Console.ReadLine().ToUpper();
                if (accountaltertype == "D")
                {
                    Console.WriteLine("Please enter deposit amount:");
                    Client.CheckingDepositAmount = double.Parse(Console.ReadLine());
                    Client.CheckingDeposit();
                    using (StreamWriter CheckingAccountSummary = new StreamWriter("CheckingAccountSummary.txt", true))
                    {
                        CheckingAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Checking Account " + DateTime.Now + " +" + Client.CheckingDepositAmount + " " + Client.CheckingBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplayCheckingsInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.CheckingWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.CheckingWithdrawal();
                    using (StreamWriter CheckingAccountSummary = new StreamWriter("CheckingAccountSummary.txt", true))
                    {
                        CheckingAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Checking Account " + DateTime.Now + " -" + Client.CheckingWithdrawalAmount + " " + Client.CheckingBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplayCheckingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto CheckingsMenu;
                }

                //using (StreamWriter CheckingAccountSummary = new StreamWriter("CheckingAccountSummary.txt", true))
                //{
                //    CheckingAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Checking Account " + DateTime.Now + " +" + Client.CheckingDepositAmount + " -" + Client.CheckingWithdrawalAmount + " " + Client.CheckingBalance + accountaltertype+"\n");
                //}

                Console.WriteLine("Would you like to make another transaction?");
                Console.WriteLine("Enter \"Y\" for yes and \"N\" for no:");
                string transactionrestart = Console.ReadLine().ToUpper();
                if (transactionrestart == "Y")
                {
                    goto MainMenu;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else if (accountselection == "2")
            {
                Console.WriteLine("Would you like to make a withdrawal or deposit?");
                Console.WriteLine("Type W for withdrawal or D for deposit:");
            SavingsMenu:
                string accountaltertype = Console.ReadLine().ToUpper();
                if (accountaltertype == "D")
                {
                    Console.WriteLine("Please enter deposit amount:");
                    Client.SavingsDepositAmount = double.Parse(Console.ReadLine());
                    Client.SavingsDeposit();
                    using (StreamWriter SavingsAccountSummary = new StreamWriter("SavingsAccountSummary.txt", true))
                    {
                        SavingsAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Savings Account " + DateTime.Now + " +" + Client.SavingsDepositAmount + " " + Client.SavingsBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplaySavingsInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.SavingsWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.SavingsWithdrawal();
                    using (StreamWriter SavingsAccountSummary = new StreamWriter("SavingsAccountSummary.txt", true))
                    {
                        SavingsAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Savings Account " + DateTime.Now + " -" + Client.SavingsWithdrawalAmount + " " + Client.SavingsBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplaySavingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto SavingsMenu;
                }
                Console.WriteLine("Would you like to make another transaction?");
                Console.WriteLine("Enter \"Y\" for yes and \"N\" for no:");
                string transactionrestart = Console.ReadLine().ToUpper();
                if (transactionrestart == "Y")
                {
                    goto MainMenu;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else if (accountselection == "3")
            {
                Console.WriteLine("Would you like to make a withdrawal or deposit?");
                Console.WriteLine("Type W for withdrawal or D for deposit:");
            ReserveMenu:
                string accountaltertype = Console.ReadLine().ToUpper();
                if (accountaltertype == "D")
                {
                    Console.WriteLine("Please enter deposit amount:");
                    Client.ReserveDepositAmount = double.Parse(Console.ReadLine());
                    Client.ReserveDeposit();
                    using (StreamWriter ReserveAccountSummary = new StreamWriter("ReserveAccountSummary.txt", true))
                    {
                        ReserveAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Reserve Account " + DateTime.Now + " +" + Client.ReserveDepositAmount + " " + Client.ReserveBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplayReserveInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.ReserveWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.ReserveWithdrawal();
                    using (StreamWriter ReserveAccountSummary = new StreamWriter("ReserveAccountSummary.txt", true))
                    {
                        ReserveAccountSummary.WriteLine(Client.Name + " " + Client.AccountNumber + " Reserve Account " + DateTime.Now + " -" + Client.ReserveWithdrawalAmount + " " + Client.ReserveBalance + " " + accountaltertype + "\n");
                    }
                    Client.DisplaySavingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto ReserveMenu;
                }
                Console.WriteLine("Would you like to make another transaction?");
                Console.WriteLine("Enter \"Y\" for yes and \"N\" for no:");
                string transactionrestart = Console.ReadLine().ToUpper();
                if (transactionrestart == "Y")
                {
                    goto MainMenu;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Please reenter selection:");
                goto MainMenu;
            }
        }
    }
}

