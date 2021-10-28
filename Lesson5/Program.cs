using System;
using ClassLibraryLesson5;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            ArrayWorker worker1 = new ArrayWorker();

            worker1.Invert(ref array);


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            worker1.MassiveChanger(ref array, 3, 5);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
