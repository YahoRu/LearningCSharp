using System;

namespace Lesson3part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLengh = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLengh];
           

            for (int i = 0; i < arrayLengh; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int biggestIntInArray = 0;

            foreach (int var in array)
            {
                if (var > biggestIntInArray) { biggestIntInArray = var; }
            }

            int lowestIntInArray = biggestIntInArray;

            foreach (int var in array)
            {
                if (var < lowestIntInArray) { lowestIntInArray = var; }
            }

            for (int i = biggestIntInArray; i >= lowestIntInArray; i--)
            {
                for (int j = 0; j < array.Length; j++)
                {
                link:
                    if ((array[j] % i) == 0)
                    {

                        if (j == (arrayLengh - 1))
                        {
                            Console.WriteLine("НОД :" + i);
                            Console.ReadKey();
                            return;
                        }
                        else if ((array[j] % i) == 0 && (j != (arrayLengh - 1)))
                        {
                            ++j;
                            goto link;
                        }
                    }
                    else break;

                }
            }


        }
    }
}
