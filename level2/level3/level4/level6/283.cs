using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of first sorted array: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n1];

        Console.WriteLine("Enter elements of first sorted array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter size of second sorted array: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int[] arr2 = new int[n2];

        Console.WriteLine("Enter elements of second sorted array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] merged = MergeSortedArrays(arr1, arr2);

        Console.WriteLine("Merged sorted array:");
        foreach (int num in merged)
        {
            Console.Write(num + " ");
        }
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;

        int[] result = new int[n1 + n2];

        int i = 0, j = 0, k = 0;

        while (i < n1 && j < n2)
        {
            if (arr1[i] <= arr2[j])
            {
                result[k++] = arr1[i++];
            }
            else
            {
                result[k++] = arr2[j++];
            }
        }

        while (i < n1)
        {
            result[k++] = arr1[i++];
        }

        while (j < n2)
        {
            result[k++] = arr2[j++];
        }

        return result;
    }
}