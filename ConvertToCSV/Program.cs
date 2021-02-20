using System;

namespace ConvertToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Converts(new int[] {1, 3, 5, 0, 1, 5}));
            TurnToCSVString(new int[0]);
            Console.WriteLine(GetX());
        }

        static string Converts(int[] arr)
        {
            string output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                output += i < arr.Length - 1 ? arr[i].ToString() + "," : arr[i].ToString();
                int b = 6;
                b = b & 1;
                Console.WriteLine(b);
            }
            return output;
        }

        static string TurnToCSVString(int[] arr) => string.Join(",", arr);

        static int GetX()
        {
            string[] arr = { "the", "quick", "brown", "fox" };
            int x = arr[arr.Length - 1].Length;

            return x;
        }
    }
}
