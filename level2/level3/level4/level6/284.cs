using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] arr = new double[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }

        double median = FindMedian(arr);

        Console.WriteLine("Median of array is: " + median);
    }

    static double FindMedian(double[] arr)
    {
        Array.Sort(arr);
        int n = arr.Length;

        if (n % 2 != 0)
        {
            return arr[n / 2];
        }
        else
        {
            return (arr[(n / 2) - 1] + arr[n / 2]) / 2.0;
        }
    }
}