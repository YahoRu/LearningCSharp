using System;

namespace Lesson3part2
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = 14, y = 1, z = 5;

            x += y - x++ * z;
            Console.WriteLine("x = " + x + " y = " + y + " z = " +z);
            z = --x - y * 5;
            Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
            y /= x + 5 % z;
            Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
            z = x++ + y * 5;
            Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
            x = y - x++ * z;
            Console.WriteLine("x = " + x + " y = " + y + " z = " + z); 

        }
    }
}
