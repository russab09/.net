using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp2
{
    class Adult: Human
    {
        public Human adult;
        private string status = "Нет статуса";
        public List<Achieve> adultAchieves = new List<Achieve>();
        public string name;
        public int age;

        //конструктор класса Adult
        public Adult(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        //свойство, определяющее статус воспитателя
        public string Status
        {
            get
            {
                int sum = this.adultAchieves.Count;
                if (sum < 1)
                {
                    status = "Нет статуса";
                }
                else if (sum < 9)
                {
                    status = "Бронзовый статус";
                }
                else if (sum < 19)
                {
                    status = "Золотой статус";
                }
                else
                {
                    status = "Платиновый статус";
                }
                return status;
            }
        }
    }
}
