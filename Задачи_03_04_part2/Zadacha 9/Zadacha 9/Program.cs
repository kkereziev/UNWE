using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one number: ");
            string num = Console.ReadLine();

            int number = Convert.ToInt32(num);

            if (number % 5 == 0)
            {
                Console.WriteLine("The number is divided to 5.");
            }
            else
            {
                Console.WriteLine("The number is not divisible to 5.");
            }

            Console.ReadKey();


        }
    }
}