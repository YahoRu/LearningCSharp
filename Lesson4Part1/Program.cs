using System;

namespace Lesson4Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber;

            Console.WriteLine("Введите число: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            Console.WriteLine($"Числа от 1 до 1000, которые делятся на {incomingNumber}:");

            for (int i = 1; i <= 1000; i++)
            {
                if ((i % incomingNumber) == 0) Console.WriteLine(i);
            }
        }
    }
}
