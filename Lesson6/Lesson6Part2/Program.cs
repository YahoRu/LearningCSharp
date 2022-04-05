using System;

namespace Lesson6Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }
        }
    }
}
