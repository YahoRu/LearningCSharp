using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[rnd.Next(1, 101)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 1001);
            }

            for (int i = 2; i < array.Length; i += 3)
            {
                array[i] = array[i - 2] + array[i - 1];
            }
        }
    }
}
