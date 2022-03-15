using System;

namespace Lesson4Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomingNumber;
            int answer;

            Console.WriteLine("Введите число: ");

            int.TryParse(Console.ReadLine(), out incomingNumber);

            answer = incomingNumber + 1;

            while (Math.Pow(answer, 3) != incomingNumber) 
            {
                if (Math.Pow(answer, 3) == incomingNumber) break;
                else if (Math.Pow(answer, 3) < incomingNumber) answer = answer + (answer / 2);
                else answer /= 2;
            }
            Console.WriteLine(answer);
        }
    }
}
