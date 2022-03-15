using System;

namespace Lesson4Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber;
            int countOddNumbers = 0;

            Console.WriteLine("Введите число длинной 5-8 цифр: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            while (incomingNumber != 0)
            {
                if ((incomingNumber % 10) % 2 != 0) countOddNumbers++;
                incomingNumber /= 10;
            }

            Console.WriteLine(countOddNumbers);
        }
    }
}
