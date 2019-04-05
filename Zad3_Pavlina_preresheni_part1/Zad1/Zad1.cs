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
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{number}*{arr[i]}=");

                Console.WriteLine(number*arr[i]);
            }
        }
    }
}
