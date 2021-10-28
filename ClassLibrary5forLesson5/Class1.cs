using System;

namespace ClassLibrary5forLesson5
{
    public class Cone
    {
        private double Radius { get; set; }
        private double High { get; set; }

        public Cone(double r, double h)
        {
            Radius = r;
            High = h;
        }

        public double SurfaceArea()
        {
            double x = (Math.PI * Math.Pow(Radius, 2));
            Console.WriteLine(x);
            return (Math.PI * Math.Pow(Radius, 2));
        }


    }
}
