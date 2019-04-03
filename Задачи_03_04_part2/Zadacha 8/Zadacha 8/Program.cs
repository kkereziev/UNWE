using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius: ");
            string num = Console.ReadLine();

            int r = Convert.ToInt32(num);

            double s = 4 * Math.PI * r * r;
            double v = 3 / 4.0 * Math.PI * r * r * r;

            Console.WriteLine("The face is = " + s);
            Console.WriteLine("The volume is = " + v);

            Console.ReadKey();
        }
    }
}
