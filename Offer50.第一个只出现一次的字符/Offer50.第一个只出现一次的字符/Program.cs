using System;
using System.Collections.Generic;

namespace Offer50.第一个只出现一次的字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("abaccdeff"));
        }
        public static char FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return ' ';
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 0);
                }

                dict[s[i]]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return s[i];
                }
            }
            return ' ';
        }
    }
}
