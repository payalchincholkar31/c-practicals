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

        FindEquilibriumIndex(arr);
    }

    static void FindEquilibriumIndex(int[] arr)
    {
        int totalSum = 0;

        foreach (int num in arr)
            totalSum += num;

        int leftSum = 0;
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            totalSum -= arr[i]; // right sum

            if (leftSum == totalSum)
            {
                Console.WriteLine("Equilibrium index is: " + i);
                found = true;
            }

            leftSum += arr[i];
        }

        if (!found)
        {
            Console.WriteLine("No equilibrium index found.");
        }
    }
}