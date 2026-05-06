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

        int result = FindMajorityElement(arr);

        if (IsMajority(arr, result))
            Console.WriteLine("Majority element is: " + result);
        else
            Console.WriteLine("No majority element found.");
    }

    static int FindMajorityElement(int[] arr)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in arr)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }

    static bool IsMajority(int[] arr, int candidate)
    {
        int count = 0;

        foreach (int num in arr)
        {
            if (num == candidate)
                count++;
        }

        return count > arr.Length / 2;
    }
}