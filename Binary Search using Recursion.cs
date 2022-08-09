using System;
using System.Data;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {12, 34, 64, 75, 86, 123, 156, 1224};
            int target  = 65;
            int chek = searchbs(arr, target, 0, arr.Length-1);
            Console.WriteLine(chek);
        }

        static int searchbs(int[] arr, int target,int s, int e)
        {
            if (s > e)
            {
                return -1;
            }
            int m = s + (e - s) / 2;
            
            if (arr[m] == target)
            {
                return m;
            }

            if (target < arr[m])
            {
                return searchbs(arr, target, s, m - 1);
            }
            
            return searchbs(arr, target, m + 1, e);
        }
    }
}
