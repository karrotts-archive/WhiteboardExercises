using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class Sorter
    {
        public static int[] BubbleSort(int[] arr)
        {
            int[] newarr = DeepCopyArray(arr);

            for (int i = 0; i < newarr.Length; i++)
            {
                for (int j = i; j < newarr.Length - 1; j++)
                {
                    if (newarr[i] >= newarr[j + 1])
                    {
                        int temp = newarr[i];
                        newarr[i] = newarr[j + 1];
                        newarr[j + 1] = temp;
                    }
                }
            }
            return newarr;
        }

        public static int[] DeepCopyArray(int[] arr)
        {
            int[] newarr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            return newarr;
        }
    }
}
