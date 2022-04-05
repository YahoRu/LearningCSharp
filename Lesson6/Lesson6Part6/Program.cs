using System;
using System.IO;

namespace Lesson6Part6
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int count = 0;
            int[,] array = new int[2, 2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t"); 
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1]) count++;
                        }
                        else if (j == (array.GetLength(1) - 1))
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1]) count++;
                        }
                        else if (array[i, j] > array[i, j - 1] && array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1])
                        {
                            count++;
                        }
                    }
                    else if (i == (array.GetLength(0) - 1))
                    {
                        if (j == 0)
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1]) count++;
                        }
                        else if (j == (array.GetLength(1) - 1))
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1]) count++;
                        }
                        else if (array[i, j] > array[i, j - 1] && array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1])
                        {
                            count++;
                        }
                    }
                    else if (i != 0 && j != 0 && i < (array.GetLength(0) - 1) && j < (array.GetLength(1) - 1))
                    {
                        if(array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1] &&
                           array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1]) count++;
                    }
                }
            }

            Console.WriteLine($"Количество элементов массива, больше всех своих соседей одновременно: {count}");
        }
    }
}
