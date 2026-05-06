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

        Console.Write("Enter value of k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k <= 0 || k > n)
        {
            Console.WriteLine("Invalid value of k");
            return;
        }

        int result = FindKthLargest(arr, k);

        Console.WriteLine(k + "-th largest element is: " + result);
    }

    static int FindKthLargest(int[] arr, int k)
    {
        Array.Sort(arr);
        Array.Reverse(arr); // descending order

        return arr[k - 1];
    }
}