using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter main string: ");
        string mainStr = Console.ReadLine();

        Console.Write("Enter substring: ");
        string subStr = Console.ReadLine();

        int index = FindSubstringIndex(mainStr, subStr);

        if (index != -1)
            Console.WriteLine("Substring found at index: " + index);
        else
            Console.WriteLine("Substring not found.");
    }

    static int FindSubstringIndex(string mainStr, string subStr)
    {
        int n = mainStr.Length;
        int m = subStr.Length;

        for (int i = 0; i <= n - m; i++)
        {
            int j;

            for (j = 0; j < m; j++)
            {
                if (mainStr[i + j] != subStr[j])
                    break;
            }

            if (j == m)
                return i;
        }

        return -1;
    }
}