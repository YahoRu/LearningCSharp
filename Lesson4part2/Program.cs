using System;

namespace Lesson4part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 201;

            string result = null;

            while (counter < 500)
            {

                if((counter % 17) == 0)
                {
                    result = result + counter.ToString() + " ; ";
                }

                ++counter;

            }

            Console.WriteLine(result);
        }
    }
}
