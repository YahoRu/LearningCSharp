using System;

namespace Lesson3Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите два числа через Enter: ");

            int.TryParse(Console.ReadLine(), out a);

            int.TryParse(Console.ReadLine(), out b);

            if (a > b) Console.WriteLine(a + b);
                else if (a < b) Console.WriteLine(a - b);
                    else Console.WriteLine(a * b);
        }
    }
}
