using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 4, 3, 5, 2,1, 4, 3, 5, 2};
            BubbleSort(arr);
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i< arr.Length-1 ; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(",",arr));
        }
    }
}
