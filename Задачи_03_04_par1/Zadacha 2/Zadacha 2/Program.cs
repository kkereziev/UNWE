using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 numbers:");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            string fourth = Console.ReadLine();

            int num1 = Convert.ToInt32(first);
            int num2 = Convert.ToInt32(second);
            int num3 = Convert.ToInt32(third);
            int num4 = Convert.ToInt32(fourth);

            double average = (num1 + num2 + num3 + num4)/ 4.0;

            Console.WriteLine("The average is = " + average);

            Console.ReadKey();


        }
    }
}
