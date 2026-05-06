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

        SegregateEvenOdd(arr);

        Console.WriteLine("Array after segregation (Even first, Odd later):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static void SegregateEvenOdd(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            // Move left forward if even
            while (left < right && arr[left] % 2 == 0)
                left++;

            // Move right backward if odd
            while (left < right && arr[right] % 2 != 0)
                right--;

            // Swap odd (left) and even (right)
            if (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
    }
}