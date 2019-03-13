using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGN
{
    class EGN
    {
        static void Main(string[] args)
        {
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };            
            string egnInput = Console.ReadLine().Trim();
            int sum;
            int controlNum;
            if (egnInput.Length != 10)
            {
                Console.WriteLine("1Невалидно ЕГН!");
                return;                
            }
            DateTime date = DateTime.Now;           
            int year = int.Parse(egnInput.Substring(0, 2));
            int month = int.Parse(egnInput.Substring(2, 2));
            int day = int.Parse(egnInput.Substring(4, 2));
            if (month>=20 && month<40 )
            {
                year += 1800;
                month -= 20;
            }
            else if (month>=40)
            {
                year += 2000;
                month -= 40;
            }
            else
            {
                year += 1900;
            }            
            DateTime dateOfBirth = new DateTime(year, month, day);
            int yearsOld = Math.Abs((date.Year -dateOfBirth.Year));
            int montsOld = Math.Abs((date.Month - dateOfBirth.Month));
            int daysOld = Math.Abs((date.Day - dateOfBirth.Day));
            sum = 0;
            for (int i = 0; i <=8; i++)
            {
                sum += (Convert.ToInt32(egnInput[i].ToString()) * Convert.ToInt32(weights[i].ToString()));                
            }
            sum = sum % 11;
            if (sum <= 10)
            {
                controlNum = 0;
                Console.WriteLine($"{yearsOld} години, {montsOld} месеца, {daysOld} дни, контролна цифра: {controlNum}");
            }
            else
            {
                Console.WriteLine("Невалидна контролна цифра.");
            }             
            
        }                          
    }
}
