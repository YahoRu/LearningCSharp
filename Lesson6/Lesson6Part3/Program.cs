using System;

namespace Lesson6Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7, 7];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0) array[i, j] = 1;
                    else array[i, j] = 0;
                }
            }
        }
    }
}
