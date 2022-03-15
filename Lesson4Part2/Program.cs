using System;

namespace Lesson4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber;
            int count = 0;

            Console.WriteLine("Введите число: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            for (int i = 1; i < Math.Sqrt(incomingNumber); i++)
            {
                if (Math.Pow(i, 2) < incomingNumber) count++;
            }

            Console.WriteLine($"Количество положительных целых чисел, квадрат которых меньше {incomingNumber}: {count}. ");
        }
    }
}
