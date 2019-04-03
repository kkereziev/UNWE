using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius: ");
            string num = Console.ReadLine();

            int r = Convert.ToInt32(num);

            double p = Math.PI * r * 2;

            Console.WriteLine("The face is = " + p);

            Console.ReadKey();





        }
    }
}
