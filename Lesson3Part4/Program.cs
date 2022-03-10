using System;

namespace Lesson3Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите три числа через Enter: ");

            double.TryParse(Console.ReadLine(), out a);

            double.TryParse(Console.ReadLine(), out b);

            double.TryParse(Console.ReadLine(), out c);

            double d = Math.Pow(b, 2) - (4 * a * c);

            if (d < 0) Console.WriteLine("Корней нет");
            else if (d == 0)
            {
                double temp = (-b) / (2.0 * a);
                Console.WriteLine($"Один корень: {temp}");
            }
            else
            {
                double temp1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double temp2 = ((-b) - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"Два корня: {temp1} и {temp2}");
            }
        }
    }
}
