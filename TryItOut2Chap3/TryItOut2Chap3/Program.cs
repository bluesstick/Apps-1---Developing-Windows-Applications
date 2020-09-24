using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut2Chap3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumer, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("Now give me  a number:");
            firstNumer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another a number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumer, secondNumber,
                firstNumer + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.", secondNumber,
                firstNumer, firstNumer - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumer,
                secondNumber, firstNumer * secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.", firstNumer,
                secondNumber, firstNumer % secondNumber);
            Console.ReadKey();
        }
    }
}
