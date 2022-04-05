using System;

namespace Lesson6Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] array1 = new int[5, 5];
            int[,] array2 = new int[5, 5];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rnd.Next(0, 10);
                    array2[i, j] = rnd.Next(0, 10);
                }
            }

            int[,] array3 = MatrixMultiplier.ArraySum(array1, array2);
        }
    }
}
