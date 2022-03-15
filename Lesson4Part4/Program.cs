using System;

namespace Lesson4Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int sum = 0;

            Console.WriteLine("Введите два числа через Enter:");

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if ((i % 7) == 0) sum += i;
            }

            Console.WriteLine($"Сумма всех чисел из диапазона от {a} до {b}, которые делятся без остатка на 7: {sum}");
        }
    }
}
