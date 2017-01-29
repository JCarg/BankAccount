using System;
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
            Client.DisplayInfo();
            Console.WriteLine("Please select the account you would like to access.");
            Console.WriteLine("Type number of selection:");
            Console.WriteLine("1. Checkings");
            Console.WriteLine("2. Savings");
            Console.WriteLine("3. Reserve");
            MainMenu:
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
                    //Client.DisplayCheckingsInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.CheckingWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.CheckingWithdrawal();
                    //Client.DisplayCheckingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto CheckingsMenu;
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
                    //Client.DisplaySavingsInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.SavingsWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.SavingsWithdrawal();
                    //Client.DisplaySavingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto SavingsMenu;
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
                    //Client.DisplayReserveInfo();
                }
                else if (accountaltertype == "W")
                {
                    Console.WriteLine("Please enter withdrawal amount:");
                    Client.ReserveWithdrawalAmount = double.Parse(Console.ReadLine());
                    Client.ReserveWithdrawal();
                    //Client.DisplaySavingsInfo();
                }
                else
                {
                    Console.WriteLine("Please reenter selection:");
                    goto ReserveMenu;
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
