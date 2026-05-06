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

        MoveZerosToEnd(arr);

        Console.WriteLine("Array after moving zeros to end:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static void MoveZerosToEnd(int[] arr)
    {
        int index = 0;

        // Move non-zero elements forward
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[index] = arr[i];
                index++;
            }
        }

        // Fill remaining positions with 0
        for (int i = index; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
    }
}