using System;

namespace Offer_10_1_斐波那契数列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(5));
        }
        public static int Fib(int n)
        {
            if (n <= 1) return n;
            int p = 0;
            int q = 1;
            int num = 0;
            for (int i = 2; i <= n; i++)
            {
                num = (q + p) % 1000000007;
                p = q;
                q = num;
            }
            return num;


        }
    }
}
