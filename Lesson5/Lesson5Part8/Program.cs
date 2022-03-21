using System;

namespace Lesson5Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 8, 5, 4, 3, 6, 1, 2 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
