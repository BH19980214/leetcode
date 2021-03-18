using System;

namespace _551.学生出勤记录1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckRecord("PPALLPL"));
            Console.ReadKey();
        }
        public static bool CheckRecord(string s)
        {
            int m = 0;
            for (int i = 0; i < s.Length && m < 2; i++)
            {
                if (s[i] == 'A')
                {
                    m++;
                }
            }
            return m < 2 && !s.Contains("LLL") ? true : false;
        }
    }
}
