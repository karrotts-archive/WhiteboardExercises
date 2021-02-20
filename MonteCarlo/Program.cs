//1. Why do we multiply the value from step 5 above by 4?
//   We multiply this value by 4 because the ratio of the area of the circle to the area of the 
//   square would be PI/4.

//2. What do you observe in the output when running your program with parameters of increasing size?
//   The estimation to PI becomes more accurate.

//3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
//   No, this is because we are using random numbers instead of a fixed numbers for the inputs.

//4. Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
//   1000000

//5. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
//   The Monte Carlo simulation can calculate movement of asset prices. Monte Carlo methods are widely 
//     used in engineering for sensitivity analysis and quantitative probabilistic analysis in process design.

using System;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = Int32.Parse(args[0]);
            int counter = 0;
            for (int i = 0; i < iterations; i++)
            {
                Point p = new Point(new Random());
                if (CalculateHypotenuse(p) <= 1)
                    counter++;
            }
            double estimation = ((double)counter / (double)iterations) * 4;
            Console.WriteLine($"Monte-Carlo estimation: {estimation}\n" +
                              $"Absolute difference between PI: {(Math.Abs(estimation - Math.PI))}");
        }

        public struct Point
        {
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Point(Random random)
            {
                x = random.NextDouble();
                y = random.NextDouble();
            }

            public double x;
            public double y;
        }

        public static double CalculateHypotenuse(Point p) => Math.Sqrt(p.x * p.x + p.y * p.y);
    }
}
