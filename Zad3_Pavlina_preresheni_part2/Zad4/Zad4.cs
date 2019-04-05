using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first array: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the second array: ");
            int b = int.Parse(Console.ReadLine());            
            int[] array1 = new int[a];
            int[] array2 = new int[b];
            bool isTrue = true;
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Element number {i+1}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Element number {i + 1}: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                     
                        isTrue = false;
                        break;

                    }
                   
                }
if(isTrue)
                {
Console.WriteLine("Масивите са еднакви.");
                }
                else
                {
                    Console.WriteLine("Масивите не са еднакви, но имат еднаква дължина.");
                }
            }
            else
            {
                Console.WriteLine("Масивите не са еднакви.");
            }
        }
    }
}