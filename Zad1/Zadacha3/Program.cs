using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one number:");
            int num = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(num, 2);
            Console.WriteLine("Result is = " + binary);
            Console.ReadKey();
        }
    }
}
