using System;
using System.Configuration;

namespace Sorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {7, 8, 4, 6, 12, 2, 9, 78, 40, 42};
            MergeSort(arr,0,arr.Length-1);
            Console.WriteLine(string.Join(",",arr));

        }

        static void MergeSort(int[] arr, int start,int end)
        {
            int mid = (start+end) / 2;
            if (start < end)
            {
                MergeSort(arr,start,mid);
                MergeSort(arr,mid+1,end);
            }
            Merge(arr,start,mid,end);
        }

        static void Merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++) {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++) {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2) {
                if (L[i] <= R[j]) {
                    arr[k] = L[i];
                    i++;
                } else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1) {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2) {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
