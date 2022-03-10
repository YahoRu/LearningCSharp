using System;

namespace Lesson3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите два числа через Enter: ");

            int.TryParse(Console.ReadLine(), out x);

            int.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0) Console.WriteLine($"Точка с координатами {x},{y} пренадлежит первой четверти");
            else if (x > 0 && y < 0) Console.WriteLine($"Точка с координатами {x},{y} пренадлежит второй четверти");
            else if (x < 0 && y < 0) Console.WriteLine($"Точка с координатами {x},{y} пренадлежит третьей четверти");
            else if (x < 0 && y > 0) Console.WriteLine($"Точка с координатами {x},{y} пренадлежит четвертой четверти");
            else Console.WriteLine($"Одна или несколько точек {x},{y} является нулем и лежит на пересечении линии координат");
        }
    }
}
