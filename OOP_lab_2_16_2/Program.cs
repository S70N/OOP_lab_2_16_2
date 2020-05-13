using System;

namespace OOP_lab_2_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25;

            while (x <= 6.75)
            {
                double y = Math.Sqrt(Math.Sqrt(x));

                Console.WriteLine("x = {0:f2}, y = {1:f4}", x, y);

                x += 0.25;
            }
        }
    }
}
