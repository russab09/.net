using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Animal[3];
            array[0] = new Fish("Whale");
            array[1] = new Bird("Collibry");
            array[2] = new Insect("Arachnid");
            for (int i = 0; i < array.Length; i++)
            {
                var animal1 = array[i] as Fish;
                if (animal1 != null)
                {
                    animal1.Eating();
                    animal1.ForFish();
                }
                var animal2 = array[i] as Bird;
                if (animal2 != null)
                {
                    animal2.Live();
                    animal2.ForBird();
                }
                var animal3 = array[i] as Insect;
                if (animal3 != null)
                {
                    animal3.Older();
                    animal3.ForInsect();
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
        }
    }
}
