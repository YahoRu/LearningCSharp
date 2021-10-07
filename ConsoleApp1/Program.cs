using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nails = rnd.Next(1, 10);

            static void hummerANail()
            {
                Random rnd = new Random();
                int hitsToNailDone = rnd.Next(1, 5);
                for (int i = 1; i <= hitsToNailDone; i++)
                {
                    Console.WriteLine("Удар по гвоздю!!");
                }
            }

            for (int i = 1; i <= nails; i++)
            {
                hummerANail();
                Console.WriteLine("Забили" + i + " гвоздь");
            }

            Console.WriteLine("Все гвозди (" + nails + " шт) " + " забиты");
            Console.ReadKey();
        }
    }
}
