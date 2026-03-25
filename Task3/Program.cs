using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 1, 1, 0, 1, 1, 1 };
        int k = 1;
        Console.WriteLine($"Array: [{string.Join(", ", nums)}], k = {k}");
        Console.WriteLine($"Maximum consecutive ones: {LongestOnes(nums, k)}");
    }

    public static int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int zeroCount = 0;
        int maxLength = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                zeroCount++;
            }

            while (zeroCount > k)
            {
                if (nums[left] == 0)
                {
                    zeroCount--;
                }
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}