using System;

namespace Lesson5Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int tmp;
            if ((array.Length % 2) == 0) tmp = 0;
            else tmp = 1;

            int[] tempArray1 = new int[(array.Length / 2) + tmp];

            Array.Copy(array, 0, tempArray1, 0, tempArray1.Length);
            Array.Copy(array, (array.Length / 2) + tmp, array, 0, array.Length / 2);
            Array.Copy(tempArray1, 0, array, (array.Length / 2), tempArray1.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
