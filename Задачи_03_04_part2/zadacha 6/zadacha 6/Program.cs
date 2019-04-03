using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three letters:");
            string let1 = Console.ReadLine();
            string let2 = Console.ReadLine();
            string let3 = Console.ReadLine();

            string one = let1;
            let1 = let3;           
            let2 = let2;
            let3 = one;

            Console.WriteLine("Result is: " + let1 + let2 + let3);
            Console.ReadKey();


        }
    }
}
