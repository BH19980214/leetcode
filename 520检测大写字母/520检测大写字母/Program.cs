using System;

namespace _520检测大写字母
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetectCapitalUse("USA"));
            Console.ReadKey();
        }


        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }
            if (char.IsLower(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
            }
            if (char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!(char.IsUpper(word[i]) == char.IsUpper(word[i + 1])) ||!( char.IsLower(word[i]) == char.IsLower(word[i + 1])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
