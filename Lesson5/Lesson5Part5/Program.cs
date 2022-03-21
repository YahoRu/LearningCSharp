using System;

namespace Lesson5Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int shiftLength = 3;

            int[] tmp = new int[shiftLength];

            Array.Copy(array, array.Length - shiftLength, tmp, 0, shiftLength);

            for (int i = array.Length - 1; i != 0; i--)
            {
                if ((i - shiftLength) < 0) break;

                array[i] = array[i - shiftLength];
            }

            Array.Copy(tmp, 0, array, 0, shiftLength);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }
    }
}
