using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Fish: Animal
    {
        /// <summary>
        /// Class of Fish
        /// </summary>
        public string Color;
        public Fish(string name):base(name)
        {
            _name = name;
            Age = 6;
            Weight = 1000;
            Name = "Whale";
            Color = "White";
        }
        public virtual void ForFish()
        {
            Console.WriteLine($"{Color} {Name} весит {Weight} килограммов при том, что ему {Age} лет");
            Console.WriteLine($"{Color} {Name} очень красивый и очень редкий");
        }
        /// <summary>
        /// Transform Fish characteristics to string
        /// </summary>
        /// <returns>String like "Name:{Color} {Name}, age: {Age}, weight: {Weight}";"</returns>
        public override string ToString()
        {
            return $"Имя:{Name} {Color}, возраст: {Age}, вес: {Weight}";
        }
    }
}
