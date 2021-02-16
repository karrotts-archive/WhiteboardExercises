using System;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRIMES
            //2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97

            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(IsPrime(7));
            Console.WriteLine(IsPrime(11));
            Console.WriteLine(IsPrime(23));
            Console.WriteLine(IsPrime(31));
            Console.WriteLine(IsPrime(53));

            // NOT PRIME
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(6));
            Console.WriteLine(IsPrime(18));
            Console.WriteLine(IsPrime(24));
            Console.WriteLine(IsPrime(100));
            Console.WriteLine(IsPrime(44));
            Console.WriteLine(IsPrime(26));
            Console.WriteLine(IsPrime(8));

            Console.WriteLine(SumOfPrimes(18));
            Console.WriteLine(SumOfPrimes(181));
        }

        static bool IsPrime(int num)
        {   
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static int SumOfPrimes(int num)
        {
            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                sum += IsPrime(i) ? i : 0;
            }
            return sum;
        }
    }
}
