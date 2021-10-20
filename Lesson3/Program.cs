using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала радиус, а затем образующую конуса, отделяя дробную часть запятой: ");

            double r = double.Parse(Console.ReadLine());

            double l = double.Parse(Console.ReadLine());

            const double pi = Math.PI;

            double s = pi * r * (r + l);

            Console.WriteLine("полщадь конуса: " + s);

        }
    }
}
