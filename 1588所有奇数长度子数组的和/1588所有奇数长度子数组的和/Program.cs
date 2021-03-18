using System;

namespace _1588所有奇数长度子数组的和
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1, 4, 2, 5, 3 };
      int i = M(arr);
      Console.WriteLine(i);
      Console.ReadKey();
    }

    public static int M(int[] arr)
    {
      int sum = 0;
      for (int n = 1; n <= arr.Length; n += 2)
      {
        for (int i = 0; i <= arr.Length - n; i++)
        {
          for (int j = i; j < i + n; j++)
          {
            sum += arr[j];
          }
        }
      }
      return sum;
    }




  }
}
