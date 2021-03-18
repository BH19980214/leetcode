using System;
using System.Collections.Generic;
using System.Linq;

namespace _896.单调数列
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 7, 6 };
            Console.WriteLine(IsMonotonic(A));

        }

        //Enumerable.SequenceEqual（A,B）
        //意思是判断两个是不是数组是不是相同的


        public static bool IsMonotonic(int[] A)
        {
            if (A.Length == 1) return true;
            List<int> list = A.ToList();
            list.Sort();//正着排序
            if (Enumerable.SequenceEqual(list.ToArray(), A)) return true;
            else
            {
                list.Reverse();//倒着排序
                if (Enumerable.SequenceEqual(list.ToArray(), A)) return true;
            }
            return false;
        }
    }
}
