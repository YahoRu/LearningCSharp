using System;

namespace Lesson5Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array1 = new int[rnd.Next(1, 101)];
            int[] array2 = new int[rnd.Next(1, 101)];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 1001);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 1001);
            }

            int[] array3 = new int[array1.Length + array2.Length];

            array1.CopyTo(array3, 0);
            array2.CopyTo(array3, (array1.Length));
        }
    }
}
