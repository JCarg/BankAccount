﻿using System;
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
            Console.WriteLine("Please Deposit:");
            Client.DepositAmount = double.Parse(Console.ReadLine());
            


        }
    }
}
