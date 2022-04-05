using System;

namespace Lesson6Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] charArray = new char[7, 7];

            int temp = 0;
            bool flag = false;

            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                for (int j = 0 + temp; j < charArray.GetLength(1) - temp; j++)
                {
                    charArray[i, j] = '1';
                }
                if (!flag) temp++;
                    else temp--;

                if (temp == 3)
                {
                    flag = true;
                }
            }

            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                for (int j = 0; j < charArray.GetLength(1); j++)
                {
                    if (charArray[i, j] != '1') charArray[i, j] = '0';
                    Console.Write($"{charArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
