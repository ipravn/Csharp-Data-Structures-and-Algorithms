using System;
using System.Data;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine(rec(number));
        }

        public static int rec(int i)
        {
            if (i == 1)
            {
                return i;
            }

            return i * rec(i - 1);
        }
    }
}
