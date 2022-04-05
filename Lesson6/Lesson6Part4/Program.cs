using System;

namespace Lesson6Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] array = new int[8, 14];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1 && array[i, j - 1] == 1)
                    {
                        Console.WriteLine($"В {i} ряду не соблюдаются антиковидные меры!");
                        break;
                    }
                }
            }

        }
    }
}
