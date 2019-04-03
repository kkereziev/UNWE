using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature in Celsius:");
            string num = Console.ReadLine();

            int temp = Convert.ToInt32(num);

            int kelvin = temp + 273;
            double fahrenheit = (temp * 18) / (10.0 + 32);

            Console.WriteLine("The Kelvin is = " + kelvin);
            Console.WriteLine("The Fahrenheit is = " + fahrenheit);

            Console.ReadKey();


        }
    }
}
