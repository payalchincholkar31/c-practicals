using System;

class OutRefDemo
{
    // Method using 'out' keyword
    static void CalculateSquareAndCube(int number, out int square, out int cube)
    {
        square = number * number;
        cube = number * number * number;
    }

    // Method using 'ref' keyword
    static void Increment(ref int number)
    {
        number += 1;
    }

    static void Main()
    {
        int num;

        // Using 'out' keyword
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        CalculateSquareAndCube(input, out int sq, out int cu);
        Console.WriteLine($"Square: {sq}, Cube: {cu}");

        // Using 'ref' keyword
        int count = 5;
        Console.WriteLine("Before Increment: " + count);
        Increment(ref count);
        Console.WriteLine("After Increment: " + count);
    }
}