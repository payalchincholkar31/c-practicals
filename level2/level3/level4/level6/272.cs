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

        Console.Write("Enter target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        FindPairs(arr, target);
    }

    static void FindPairs(int[] arr, int target)
    {
        bool found = false;

        Console.WriteLine("Pairs with given sum:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine("(" + arr[i] + ", " + arr[j] + ")");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No pairs found.");
        }
    }
}