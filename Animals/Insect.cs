using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Insect: Animal
    {
        /// <summary>
        /// Class of Insect
        /// </summary>
        public int NumberOfLegs;
        public Insect(string name):base(name)
        {
            _name = name;
            Age = 1;
            Weight = 1;
            NumberOfLegs = 8;
            Name = "Arachnid";
        }
        public virtual void ForInsect()
        {
            Console.WriteLine($"{Name} весит {Weight} килограммов, имеет {NumberOfLegs} конечностей и ему {Age} лет");
            Console.WriteLine($"{Name} очень опасен");
        }
        /// <summary>
        /// Transform Insect characteristics to string
        /// </summary>
        /// <returns>String like "Name:{Color} {Name}, age: {Age}, weight: {Weight}";"</returns>
        public override string ToString()
        {
            return $"Имя:{Name}, количество конечностей:{NumberOfLegs}, возраст: {Age}, вес: {Weight}";
        }
    }
}
