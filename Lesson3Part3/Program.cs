using System;

namespace Lesson3Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите три числа через Enter: ");

            int.TryParse(Console.ReadLine(), out a);

            int.TryParse(Console.ReadLine(), out b);

            int.TryParse(Console.ReadLine(), out c);

            if (a >= b && a >= c)
            {
                if (b >= c) Console.WriteLine($"{c}, {b}, {a}");
                else Console.WriteLine($"{b}, {c}, {a}");
            }
            else if (b >= a && b >= c)
            {
                if (a >= c) Console.WriteLine($"{c}, {a}, {b}");
                else Console.WriteLine($"{a}, {c}, {b}");
            }
            else
            {
                if (a >= b) Console.WriteLine($"{b}, {a}, {c}");
                else Console.WriteLine($"{a}, {b}, {c}");
            }

        }
    }
}
