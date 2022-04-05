using System;

namespace Lesson6Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            double[,] array = new double[10, 6];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.NextDouble() * 2000000 + 1000000;
                    Console.Write($"{array[i, j]:f2}\t");
                }
                Console.WriteLine();
            }

            double[] sum_income_per_shop = new double[array.GetLength(0)];
            double[] avg_income_per_mounth = new double[array.GetLength(1)];

            double min_array = array[0, 0];
            double max_array = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    avg_income_per_mounth[j] += array[i, j];
                    sum_income_per_shop[i] += array[i, j];

                    if (array[i, j] < min_array) min_array = array[i, j];
                    if (array[i, j] > max_array) max_array = array[i, j];

                    if (i == (array.GetLength(0) - 1))
                    {
                        avg_income_per_mounth[j] /= array.GetLength(1);
                    }
                }
            }

            Console.WriteLine($"Мин {min_array}");
            Console.WriteLine($"Макс {max_array}");

            Console.WriteLine($"сумма доходов каждого магазина:");
            for (int i = 0; i < sum_income_per_shop.Length; i++)
            {
                Console.WriteLine($"{sum_income_per_shop[i]:f2}");
            }

            Console.WriteLine($"средний доход за каждый месяц:");
            for (int i = 0; i < avg_income_per_mounth.Length; i++)
            {
                Console.WriteLine($"{avg_income_per_mounth[i]:f2}");
            }
        }
    }
}
