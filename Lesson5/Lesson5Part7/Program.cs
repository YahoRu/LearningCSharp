using System;

namespace Lesson5Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[rnd.Next(1, 101)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, 21);
            }

            int minAbs = int.MaxValue;
            int sumAfterZero = 0;
            bool flag = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minAbs) minAbs = Math.Abs(array[i]);

                if (flag) sumAfterZero += array[i];
                else if (array[i] == 0 && !flag)flag = true;
            }

            Console.WriteLine(minAbs);
            Console.WriteLine(sumAfterZero);
        }
    }
}
