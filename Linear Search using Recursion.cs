using System;
using System.Data;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] n = {1, 2, 3, 8, 9, 12, 11, 4,19};
            int target = 3;
            Console.WriteLine(LSearch(n,target,0));
            
        }
        
        
        public static int LSearch(int[] n,int target,int index)
        {
            if (n.Length <= index )
            {
                return -1;
            }

            if (n[index] == target)
            {
                return index;
            }
            else if (index <= n.Length) 
            {
                return LSearch(n, target, index + 1);
            }
                      
        }

    }
}
