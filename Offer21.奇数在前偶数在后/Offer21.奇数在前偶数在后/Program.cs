using System;
using System.Collections.Generic;

namespace Offer21.奇数在前偶数在后
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange(new int[] { 1,2,3}));
        }
        public static int[] Exchange(int[] nums)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    list2.Add(nums[i]);
                }
                else
                {
                    list1.Add(nums[i]);
                }
            }
            list.AddRange(list1);
            list.AddRange(list2);
            return list.ToArray();
        }
    }
}
