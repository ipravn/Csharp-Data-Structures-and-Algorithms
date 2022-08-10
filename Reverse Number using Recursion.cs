using System;
using System.Data;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 1034;
            Console.WriteLine(rev(number));
        }

        private static int sum = 0;

        public static int rev(int i)
        {
            if (i == 0)
            {
                return sum;
            }

            int num = i % 10;
            sum = sum * 10 + num;
            return rev(i / 10);

        }
    }
}
