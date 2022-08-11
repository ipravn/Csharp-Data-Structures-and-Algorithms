using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 4, 3, 5, 2};
            Console.WriteLine(string.Join(",",SelectionSort(arr)));
        }

        static int[]  SelectionSort(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                int last = arr.Length - i - 1;
                int maxIndex = getMaxIndex(arr, 0, last);
                swap(arr, maxIndex, last);
            }
            return arr;
        }

        static int[] swap(int[] arr, int first, int second) {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            return arr;
        }

        static int getMaxIndex(int[] arr, int start, int end) {
            int max = start;
            for (int i = start; i <= end; i++) {
                if (arr[max] < arr[i]) {
                    max = i;
                }
            }
            return max;
        }
    }
}
