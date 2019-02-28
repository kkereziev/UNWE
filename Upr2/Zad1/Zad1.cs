using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Zad1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.Write($"{number}*{i}=");
                Console.WriteLine(number*i);
            }
        }
    }
}
