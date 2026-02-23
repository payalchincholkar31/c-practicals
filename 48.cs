using System;

class Program
{
    static void Main()
    {
        string name = "Payal";
        int age = 21;
        double marks = 85.5;

        // String Interpolation using $
        string message = $"My name is {name}, I am {age} years old and I scored {marks} marks.";

        Console.WriteLine(message);

        Console.ReadLine();
    }
}