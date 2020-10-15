using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut4Chap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" {0} command line arguments were speccified:", args.Length);
            foreach (string arg in args)
                Console.WriteLine(arg);
            Console.ReadKey();
        }
    }
}
