using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime time = new DateTime(year, month, day);
            Console.WriteLine("Result is :"+ time.DayOfWeek);

            Console.ReadKey();
        }
    }
}
