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

        CountFrequency(arr);
    }

    static void CountFrequency(int[] arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        Console.WriteLine("Element frequencies:");

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " occurs " + item.Value + " times");
        }
    }
}