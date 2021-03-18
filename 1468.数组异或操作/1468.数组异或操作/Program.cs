using System;

namespace _1468.数组异或操作
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XorOperation(5,0));
        }
        public static int XorOperation(int n, int start)
        {
            int p = start;
            for (int i = 1; i < n; i++)
            {
                p = p ^ (start + 2 * i);
            }
            return p;
        }
    }
}
