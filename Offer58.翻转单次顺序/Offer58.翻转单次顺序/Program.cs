using System;
using System.Collections.Generic;

namespace Offer58.翻转单次顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("the sky is blue"));
        }
        public static string ReverseWords(string s)
        {
            string[] arrylist = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string str = "";
            for (int i = 0; i < arrylist.Length/2; i++)
            {
                str = arrylist[i];
                arrylist[i] = arrylist[arrylist.Length - 1 - i];
                arrylist[arrylist.Length-1 - i] = str;
            }
            List<string> list = new List<string>();
            for (int i = 0; i < arrylist.Length; i++)
            {
                list.Add(arrylist[i]);
            }
            return list.ToString();
        }
    }
}
