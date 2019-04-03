using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one number:");
            string num = Console.ReadLine();

            int number = Convert.ToInt32(num);

            if(number % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            Console.ReadKey();

        }
    }
}
