using System;
using System.Collections.Generic;

namespace Offer_40_最小的K个数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLeastNumbers(new int[] { 2, 18, 9, 26 }, 2));
        }
        public static int[] GetLeastNumbers(int[] arr, int k)
        {
            List<int> num = new List<int>();
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                num.Add(arr[i]);
            }

            //sort 的具体算法
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}





            num.Sort();
            for (int i = 0; i < k; i++)
            {
                result.Add(num[i]);
            }
            return result.ToArray();
        }
    }
}
