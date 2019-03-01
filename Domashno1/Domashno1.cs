using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashno1
{
    class Domashno1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the array: ");
            int a = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            int count = 1;
            int tempCount;
            int common = array[0];
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=========");                                 
            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (temp == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    common = temp;
                    count = tempCount;

                }

            }
            Console.Write("Most common element: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{common},");
            }
            Console.WriteLine();
        }      
    }
}
