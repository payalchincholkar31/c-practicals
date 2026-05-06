using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of first array: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n1];

        Console.WriteLine("Enter elements of first array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int[] arr2 = new int[n2];

        Console.WriteLine("Enter elements of second array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        FindUnion(arr1, arr2);
    }

    static void FindUnion(int[] arr1, int[] arr2)
    {
        HashSet<int> unionSet = new HashSet<int>();

        foreach (int num in arr1)
            unionSet.Add(num);

        foreach (int num in arr2)
            unionSet.Add(num);

        Console.WriteLine("Union of arrays:");

        foreach (int num in unionSet)
        {
            Console.Write(num + " ");
        }
    }
}