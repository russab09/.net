using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal: Interface1
    {
        /// <summary>
        /// Base class of all animals
        /// </summary>
        public string _name;
        public string Name;
        public int Age;
        public int CountEyes;
        public int Weight;
        int Interface1.Weight
        {
            get
            {
                return Weight;
            }
            set
            {

            }
        }
        int Interface1.Age
        {
            get
            {
                Age = 10;
                return Age;
            }
            set
            {

            }
        }
        public Animal(string name)
        {
            _name = name;
        }
        public virtual void Option()
        {
            Console.WriteLine($"{Name} весит {Weight} килограммов и ему {Age} лет");
        }
        public void Older()
        {
            Age++;
        }
        public void Eating()
        {
            Weight = Weight + 50;
        }

    }
}
