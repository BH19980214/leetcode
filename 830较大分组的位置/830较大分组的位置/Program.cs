using System;
using System.Collections;
using System.Collections.Generic;

namespace _830较大分组的位置
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "abbxxxxzzy";
      List<List<int>> list = new List<List<int>>();
      list = M(s);
      Console.WriteLine(list.ToString());
    }

    public static List<List<int>> M(string s)
    {
      List<List<int>> list = new List<List<int>>();
      int index = 0;
      while (index < s.Length)
      {
        int start = index;
        while (index < s.Length && s[index] == s[start]) index++;
        if (index - start >= 3)
        {
          list.Add(new List<int> { start, index - 1 });
        }
      }
      return list;
    }
  }
}
