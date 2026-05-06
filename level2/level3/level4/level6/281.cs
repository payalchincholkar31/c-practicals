using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int lisLength = LongestIncreasingSubsequence(arr);

        Console.WriteLine("Length of Longest Increasing Subsequence: " + lisLength);
    }

    static int LongestIncreasingSubsequence(int[] arr)
    {
        int n = arr.Length;
        int[] lis = new int[n];

        // Each element is LIS of length 1 initially
        for (int i = 0; i < n; i++)
            lis[i] = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        int max = 0;
        for (int i = 0; i < n; i++)
        {
            if (lis[i] > max)
                max = lis[i];
        }

        return max;
    }
}