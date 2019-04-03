using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers: ");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int num1 = Convert.ToInt32(first);
            int num2 = Convert.ToInt32(second);

            int sum = num1 + num2;
            int dif = num1 - num2;
            int multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("The sum is = " + sum);
            Console.WriteLine("The subtraction is = " + dif);
            Console.WriteLine("The multiplication is = " + multiplication);
            Console.WriteLine("The division is = " + division);

            Console.ReadKey();



        }
    }
}
