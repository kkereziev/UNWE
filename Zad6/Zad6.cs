using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad6
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of rows: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of columns: ");
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            int sum=0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Enter element of the array: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    System.Console.Write(array[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (row+col==b-1)
                    {
                        sum = sum + array[row, col];                       
                    }
                }                
            }
            Console.Write("The sum is: ");
            Console.WriteLine(sum);

        }
    }
}
