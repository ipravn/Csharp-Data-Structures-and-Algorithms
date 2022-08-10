using System;
using System.Data;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 12521;
            bool answer = pal(number);
            Console.WriteLine(answer);
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

        public static bool pal(int checkint)
        {
            return (checkint == rev(checkint));

        }

    }
}
