using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of rows: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of columns: ");
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
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
                    System.Console.Write($"{array[col, row]} ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================");

            for (int col = 1; col < array.GetLength(0); col++)
                if (col % 2 == 1)
                {
                    array[0, col] = array[0, col - 1] + a * 2 - 1;
                }
                else
                {
                    array[0, col] = array[0, col - 1] + 1;
                }
            for (int col = 1; col < array.GetLength(0); col++)
                for (int row = 0; row < array.GetLength(1); row++)
                    if (row % 2 == 1)
                    {
                        array[col, row] = array[col - 1, row] - 1;
                    }
                    else
                    {
                        array[col, row] = array[col - 1, row] + 1;
                    }

            for (int col = 0; col < array.GetLength(0); col++)
            {
                for (int row = 0; row < array.GetLength(1); row++) Console.Write($"{array[col, row]} ");
                Console.WriteLine();
            }

            }                
        }
    }
