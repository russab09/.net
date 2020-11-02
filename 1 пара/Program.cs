using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_пара
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько дней вы прожили? ");
            var days = Console.ReadLine();
            int Days = Convert.ToInt32(days);
            int year = 0, month = 0, day = 0;
            year = Days / 365;
            Days = Days % 365;
            month = Days / 30;
            day = Days % 30;
            Console.WriteLine($"Вы прожили { year} лет { month} месяцев { day} дней");
            if (year >= 18)
            {
                int k = 0;
                while (k < 10)
                {
                    k++;
                    Console.WriteLine($"{k}");
                }
                Console.WriteLine("Вы совершеннолетний");
            }
            Console.ReadKey();
        }
    }
}
