using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Bird: Animal, Interface1
    {
        /// <summary>
        /// Class of Bird
        /// </summary>
        public string Type;
        public Bird(string name) : base(name)
        {
            _name = name;
            Name = "Tari";
            Type = "Collibry";
            Weight = 1;
            Age = 5;
        }
        public void Live()
        {
            Age = 7;
        }
        public virtual void ForBird()
        {

            Console.WriteLine($"{Type} {Name} весит {Weight} килограммов при том, что ему {Age} лет");
            Console.WriteLine($"{Type} {Name} очень маленькая, быстрая и красивая");
        }
        /// <summary>
        /// Transform Bird characteristics to string
        /// </summary>
        /// <returns>String like "Name: {Vid}{Name}, age: {Age}, weight: {Weight}.";"</returns>
        public override string ToString()
        {
            return $"Имя:{Type} {Name}, возраст: {Age}, вес: {Weight}";
        }
    }
}
