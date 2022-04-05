using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Part8
{
    public static class MatrixMultiplier
    {
        public static int[,] ArraySum(int[,] firstArray, int[,] secondArray)
        {
            if (firstArray.GetLength(0) != secondArray.GetLength(0))
                throw new Exception("массивы разных размеров!");

            if (firstArray.GetLength(1) != secondArray.GetLength(1))
                throw new Exception("массивы разных размеров!");

            int[,] resutArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    resutArray[i, j] = firstArray[i, j] * secondArray[i, j];
                }
            }

            return resutArray;
        }
    }
}
