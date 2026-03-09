using System;
using System.Collections.Generic;

class CommonElementsOptimized
{
    static void Main()
    {
        // Input arrays
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        Console.WriteLine("Array 1: " + string.Join(", ", array1));
        Console.WriteLine("Array 2: " + string.Join(", ", array2));

        // Use HashSet for fast lookup
        HashSet<int> set1 = new HashSet<int>(array1);
        HashSet<int> common = new HashSet<int>();

        foreach (int num in array2)
        {
            if (set1.Contains(num))
            {
                common.Add(num); // Avoid duplicates
            }
        }

        Console.WriteLine("\nCommon Elements: " + string.Join(", ", common));
    }
}