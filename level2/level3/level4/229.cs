using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int rotated = RotateDigitsLeft(number);

        Console.WriteLine("Rotated number is: " + rotated);
    }

    static int RotateDigitsLeft(int num)
    {
        string str = num.ToString();

        // If single digit, no rotation needed
        if (str.Length == 1)
            return num;

        string rotatedStr = str.Substring(1) + str[0];

        return Convert.ToInt32(rotatedStr);
    }
}