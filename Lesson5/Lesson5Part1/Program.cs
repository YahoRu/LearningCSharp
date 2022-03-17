using System;

namespace Lesson5Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            Random rnd = new Random();

            int[] array = new int[rnd.Next(1, 101)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 1001);
            }

            foreach (var item in array)
            {
                if ((item % 2) == 0) sumEven++;
            }

            Console.WriteLine($"Количество четных элементов массива: {sumEven}; Количество нечетных элементов массива: {array.Length - sumEven}");
        }
    }
}
