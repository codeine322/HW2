using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 2, 3, 4, 4, 4 };
        Console.WriteLine($"Array: [{string.Join(", ", arr)}]");
        Console.WriteLine(FindLucky(arr));
    }

    public static int FindLucky(int[] arr)
    {
        Array.Sort(arr);

        int slow = 0;
        int maxLucky = -1;

        while (slow < arr.Length)
        {
            int currentNumber = arr[slow];
            int fast = slow;

            while (fast < arr.Length && arr[fast] == currentNumber)
            {
                fast++;
            }

            int count = fast - slow;

            if (count == currentNumber)
            {
                maxLucky = Math.Max(maxLucky, currentNumber);
            }

            slow = fast;
        }

        return maxLucky;
    }
}