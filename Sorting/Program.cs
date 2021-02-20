using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 8, 7, 6, 15, 98, 0, 55, -88, 98 };
            BubbleSort(arr);
        }

        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] >= arr[j + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
