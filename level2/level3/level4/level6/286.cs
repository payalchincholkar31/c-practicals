using System;
using System.Collections.Generic;

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

        FindDuplicates(arr);
    }

    static void FindDuplicates(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in arr)
        {
            if (!seen.Add(num)) // already exists → duplicate
            {
                duplicates.Add(num);
            }
        }

        Console.WriteLine("Duplicate elements:");

        if (duplicates.Count == 0)
        {
            Console.WriteLine("No duplicates found.");
        }
        else
        {
            foreach (int num in duplicates)
            {
                Console.Write(num + " ");
            }
        }
    }
}