using System;

namespace AreaOfCircle
{
    class Program
    {
        static double CalculateCircleArea(double radius) => Math.PI * Math.Pow(radius, 2);

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Area of a circle if radius is {i}: {CalculateCircleArea(i)}");
            }
        }
    }
}
