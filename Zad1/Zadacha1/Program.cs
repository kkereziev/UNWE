using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sides of triangle: ");
            string sideA = Console.ReadLine();
            string sideB = Console.ReadLine();
            string sideC = Console.ReadLine();

            int a = Convert.ToInt32(sideA);
            int b = Convert.ToInt32(sideB);
            int c = Convert.ToInt32(sideC);

           double perimeter = a + b + c;
            Console.WriteLine("Perimeter is "+perimeter);

            double area = (a * b) / 2.0;
            Console.WriteLine("Area of the triangle is "+area);

            Console.ReadKey();


        }
    }
}
