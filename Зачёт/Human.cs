using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp2
{
    class Human
    {
        //поле коллекции с ачивками
        public List<Achieve> Achievements;

        //метод, возвращающий кол-во ачивок за всё время
        public int SumAchieves(List<Achieve> array)
        {
            return array.Count;
        }

        //метод, возвращающий кол-во ачивок за определённый период
        public int SumAchievesForPeriod(int monthFrom, int monthTo, List<Achieve> array1, List<Achieve> array2)
        {
            int Sum = 0;
            for (int i = 0; i < array1.Count; i++)
            {
                if ((array1[i].month >= monthFrom) && (array1[i].month <= monthTo))
                {
                    Sum++;
                }
            }
            for (int i = 0; i < array2.Count; i++)
            {
                if ((array2[i].month >= monthFrom) && (array2[i].month <= monthTo))
                {
                    Sum++;
                }
            }
            return Sum;
        }

        //добавление ачивки в коллекцию с ачивками
        public void AddAchieve(int month, int points, List<Achieve> array)
        {
            array.Add(new Achieve(month, points));
        }
    }
}
