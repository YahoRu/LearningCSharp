using System;

namespace Lesson5Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 8, 5, 4, 3, 6, 1, 2 };

            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                temp = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[temp]) temp = j;
                }

                int temp2 = array[i];
                array[i] = array[temp];
                array[temp] = temp2;
            }
        }
    }
}