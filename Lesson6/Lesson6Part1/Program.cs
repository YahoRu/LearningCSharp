using System;

namespace Lesson6Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] array = new int[5, 8];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 2);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == array.GetLength(0) - 1 || j == array.GetLength(1) - 1) array[i, j] = -(array[i, j]);
                }
            }
        }
    }
}
