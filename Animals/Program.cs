using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var WhiteWhale = new Fish("Whale");
            var Collibry = new Bird("Collibry");
            var Arachnid = new Insect("Arachnid");
            Animal[] arr = new Animal[] { WhiteWhale, Collibry, Arachnid };
            Console.WriteLine("Добро пожаловать в наш зоопарк!");
            Collibry.Live();
            WhiteWhale.Eating();
            Arachnid.Older();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());

            }
            Console.WriteLine("Применение интерфейсов:");
            Collibry.Live();
            Collibry.Older();
            WhiteWhale.Eating();
            Arachnid.Older();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());

            }
        }
    }
}
