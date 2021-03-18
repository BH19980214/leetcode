using System;

namespace _1281整数的各位积和之差
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = M(234);
      Console.WriteLine(i);
      Console.ReadKey();
    }
    public static int M(int n)
    {
      int x = n % 10;
      int y = n % 10;
      while (n >= 10)
      {
        n = n / 10;
        x = x * (n % 10);
        y = y + (n % 10);
      }
      return x - y;


    }
  }
}
