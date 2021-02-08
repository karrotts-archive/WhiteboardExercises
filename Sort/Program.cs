using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortString("act"));
        }

        static string SortString(string s)
        {
            char[] schar = s.ToCharArray();

            for (int i = 0; i < schar.Length; i++)
            {
                for (int j = 0; j < schar.Length - 1; j++)
                {
                    if (schar[j] > schar[j + 1])
                    {
                        char temp = schar[j];
                        schar[j] = schar[j + 1];
                        schar[j + 1] = temp;
                    }
                }
            }

            return new string(schar);
        }
    }
}
