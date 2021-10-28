using System;
using ClassLibrary5forLesson5;

namespace Lesson5part3try
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone cone = new Cone(1.0, 3.0);

            double x = cone.SurfaceArea();

            Console.WriteLine(x);
        }
    }
}
