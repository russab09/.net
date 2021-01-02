using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание экземпляров классов Adult и Child
            Adult a = new Adult("Елена", 25);
            Child b = new Child("Дима", 4);

            //заполнение поля ачивок через Random.Next()
            for (int i = 0; i < 12; i++)
            {
                Random rand = new Random();
                int number = rand.Next(0, 5);
                for (int j = 0; j < number; j++)
                {
                    Random randd = new Random();
                    int points = randd.Next(1, 6);
                    a.AddAchieve(i + 1, points, a.adultAchieves);
                }
                number = rand.Next(0, 5);
                for (int j = 0; j < number; j++)
                {
                    Random randd = new Random();
                    int points = randd.Next(1, 8);
                    b.AddAchieve(i + 1, points, b.childAchieves);
                }
            }

            //кол-во ачивок воспитателя за всё время
            int achievesAdult = a.SumAchieves(a.adultAchieves);
            //кол-во ачивок ребёнка за всё время
            int achievesChild = b.SumAchieves(b.childAchieves);

            Console.WriteLine($"За всё время воспитатель получил { achievesAdult } ачивок, ребенок { achievesChild } ачивок");
            Console.WriteLine($"Статус воспитателя: { a.Status }");
            Console.WriteLine($"За первые три месяца выдано { a.SumAchievesForPeriod(1, 3, a.adultAchieves, b.childAchieves) } ачивок");
        }
    }
}
