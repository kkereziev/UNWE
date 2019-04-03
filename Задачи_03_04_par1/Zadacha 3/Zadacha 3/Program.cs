using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x = ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Please enter y = ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Please enter z = ");
            string num3 = Console.ReadLine();

            int x = Convert.ToInt32(num1);
            int y = Convert.ToInt32(num2);
            int z = Convert.ToInt32(num3);

            int result1 = (x + y) * z;
            int result2 = x * y + y * z;

            Console.WriteLine("Result: (x+y)*z = " + result1);
            Console.WriteLine("Result: x*y + y*z = " + result2);

            Console.ReadKey();

            
        }
    }
}
