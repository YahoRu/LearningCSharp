using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100:");

            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 30)
            {
                Console.WriteLine("Число от 0 до 30");
            }
            else if (number >= 31 && number <= 60)
            {
                Console.WriteLine("Число от 31 до 60");
            }
            else if (number >= 61 && number <= 100)
            {
                Console.WriteLine("Число от 61 до 100");
            }
            else { Console.WriteLine("Я такого числа не знаю"); }
        }
    }
}
