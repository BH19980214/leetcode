using System;

namespace offer53缺失的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNumber(new int[] { 0, 1 }));
        }
        public static int MissingNumber(int[] nums)
        {
            int sun = 0;
            if(nums[0] != 0)
            {
                return 0;
            }
            if (nums[0] == 0 && nums.Length == 1)
            {
                return 1;
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 != nums[i + 1])
                {
                    sun = nums[i] + 1;
                    break;
                }
                else if (i + 1 == nums.Length - 1)
                {
                    return nums[i + 1] + 1;
                }
            }
            return sun;
        }
    }
}
