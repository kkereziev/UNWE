using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad3
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]},");
            }
        }
    }
}
