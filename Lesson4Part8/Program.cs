using System;

namespace Lesson4Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber = 0;
            int reversedNUmber = 0;
            int zeroCounter = 1;

            Console.WriteLine("Введите число: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            int temp = incomingNumber;

            while (incomingNumber != 0)
            {
                zeroCounter *= 10;
                incomingNumber = incomingNumber / 10;
            }

            while(zeroCounter != 0)
            {
                zeroCounter /= 10;
                reversedNUmber += (temp % 10) * zeroCounter;
                temp /= 10;
            }

            Console.WriteLine(reversedNUmber);
        }
    }
}
