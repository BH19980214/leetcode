using System;
using System.Collections.Generic;

namespace Offer_05_替换空格
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceSpace("We are happy."));
        }


        public static string ReplaceSpace(string s)
        {
            List<string> list = new List<string>();
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() != " ")
                {
                    list.Add(s[i].ToString());
                }
                else if (s[i].ToString() == " ")
                {
                    list.Add("%20");
                }
            }
            foreach (string ss in list)
            {
                str += ss;
            }
            return str;
        }
    }
}
