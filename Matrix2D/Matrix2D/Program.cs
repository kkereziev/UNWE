using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] 
            { 
            { 1,2,3 }, 
            { 4,5,6 }, 
            { 7,8,9 }
            };
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    System.Console.Write(array[row,col]);
                }
                Console.WriteLine();
            }                   
        }
    }
}
