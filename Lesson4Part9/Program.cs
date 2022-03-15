using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Lesson4Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evenSum;
            int oddSum;

            Console.WriteLine("Введите  целое положительное  число: ");

            int.TryParse(Console.ReadLine(), out number);


            for (int i = 1; i <= number; i++)
            {
                evenSum = 0;
                oddSum = 0;

                for (int j = i; j != 0; j /= 10)
                {
                    if ((j % 10) % 2 == 0) evenSum += j % 10;
                    else oddSum += j % 10;
                }

                if (evenSum > oddSum) Console.WriteLine(i);
            }
        }
    }
}
