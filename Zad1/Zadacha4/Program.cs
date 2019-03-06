using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number:");
            string number = Console.ReadLine();

            string number1 = number.Substring(0, 1);
            string number2 = number.Substring(1, 1);
            string number3 = number.Substring(2, 1);
            string number4 = number.Substring(3, 1);

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            int num3 = int.Parse(number3);
            int num4 = int.Parse(number4);

            int sum = num1 + num2 + num3 + num4;

            Console.WriteLine("The sum is = " + sum);
            Console.WriteLine("dcba is " + num4 + num3 + num2 + num1);
            Console.WriteLine("dabc is " + num4 + num1 + num2 + num3);
            Console.WriteLine("acbd is " + num1 + num3 + num2 + num4);


            Console.ReadKey();

        }
    }
}
