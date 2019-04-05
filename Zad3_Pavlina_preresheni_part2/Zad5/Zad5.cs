using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Zad5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the rows of the matrix: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the columns of the matrix: ");
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
                    System.Console.Write(array[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
