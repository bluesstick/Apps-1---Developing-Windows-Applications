using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut4Chap4
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your curretn balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Whats is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine())/100.1;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine("In {0} year {1} you'll have a balance of {2}.", 
                totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();
        }
    }
}
