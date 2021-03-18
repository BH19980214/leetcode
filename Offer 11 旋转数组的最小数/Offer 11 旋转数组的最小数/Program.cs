using System;
using System.Collections.Generic;

namespace Offer_11_旋转数组的最小数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinArray(new int[] { 3, 4, 5, 1, 2 }));
        }



        public static int MinArray(int[] numbers)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                list.Add(numbers[i]);
            }
            list.Sort();
            return list[0];

        }
    }
}
