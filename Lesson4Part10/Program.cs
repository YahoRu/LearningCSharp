using System;

namespace Lesson4Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool answer = false;

            Console.WriteLine("Введите два числа через Enter: ");

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            for (int i = 0; i != a; a /= 10)
            {
                if (answer) break;
                int temp = a % 10;

                for (int j = b; j != 0; j /= 10)
                {
                    if (answer) break;
                    int temp2 = j % 10;
                    if (temp == temp2) answer = true; 
                }
            }
            Console.WriteLine(answer);
        }
    }
}
