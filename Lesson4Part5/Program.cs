using System;

namespace Lesson4Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Введите два числа через Enter: ");

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            while(a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }

            Console.WriteLine(a+b);
        }
    }
}
