using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of matrix: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int value = 1;
        int top = 0, bottom = n - 1;
        int left = 0, right = n - 1;

        while (value <= n * n)
        {
            // Left to right
            for (int i = left; i <= right; i++)
                matrix[top, i] = value++;
            top++;

            // Top to bottom
            for (int i = top; i <= bottom; i++)
                matrix[i, right] = value++;
            right--;

            // Right to left
            for (int i = right; i >= left; i--)
                matrix[bottom, i] = value++;
            bottom--;

            // Bottom to top
            for (int i = bottom; i >= top; i--)
                matrix[i, left] = value++;
            left++;
        }

        // Print matrix
        Console.WriteLine("\nSpiral Matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}