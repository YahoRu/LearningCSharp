using System;

namespace Lesson3Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите три числа через Enter:");

            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);

            if ((a + b) > c && (a + c) > b && (b + c) > a) Console.WriteLine("Треугольник с такими сторонами существует");
            else Console.WriteLine("Треугольника с такими сторонами не существует");
        }
    }
}
