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

        int maxSum = Kadane(arr);

        Console.WriteLine("Maximum subarray sum is: " + maxSum);
    }

    static int Kadane(int[] arr)
    {
        int maxCurrent = arr[0];
        int maxGlobal = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            maxCurrent = Math.Max(arr[i], maxCurrent + arr[i]);

            if (maxCurrent > maxGlobal)
                maxGlobal = maxCurrent;
        }

        return maxGlobal;
    }
}