using System;

namespace Lesson4Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber;
            int largestDivisor = 0;

            Console.WriteLine("Введите положительное число: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            for (int i = 1; i < incomingNumber; i++)
            {
                if (incomingNumber % i == 0) largestDivisor = i;
            }

            if (largestDivisor == 0) Console.WriteLine("Нет положительного целого делителя");
            else Console.WriteLine(largestDivisor);
        }
    }
}
