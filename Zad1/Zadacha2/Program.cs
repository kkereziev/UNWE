using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value :");
            string one = Console.ReadLine();
            string letter = "qwrtypsdfghjklzxcvbnm";
            string num = "0123456789";
            string two = "aeiou";

            if (letter.Contains(one))
            {
                Console.WriteLine("Agree");
            }
            else if (num.Contains(one))
            {
                Console.WriteLine("Number");

            }
            else if (two.Contains(one))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Sign");
            }

            Console.ReadKey();

        }
    }
}
