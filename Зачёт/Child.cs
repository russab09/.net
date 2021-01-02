using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp2
{
    class Child: Human
    {
        public Human child;
        public List<Achieve> childAchieves = new List<Achieve>();
        public string name;
        public int age;

        //конструкьор класса Child
        public Child(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }
}
