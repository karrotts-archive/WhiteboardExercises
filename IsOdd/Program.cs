using System;

namespace IsOddOrEven
{
    class Program
    {
        static bool IsOdd(int input) => input % 2 != 0;
        static bool IsEven(int input) => input % 2 == 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 10; i++)
            {
                string EvenOdd = IsOdd(i) ? "Odd" : "Even";
                Console.WriteLine($"{i}: is {EvenOdd}");
            }
        }
    }
}
