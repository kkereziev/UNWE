using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashno2
{
    class Domashno2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int lenght = Int32.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            int same = 1, bestSame = 1, bestStart = 0, lastElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]+1==array[i+1])
                {
                    same++;
                    if (same>bestSame)
                    {
                        bestSame = same;
                        lastElement = i + 1;
                        bestStart = lastElement-bestSame + 1;
                    }
                }
                else
                {
                    same = 1;
                }
            }
            for (int i = bestStart; i < bestSame+bestStart; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
