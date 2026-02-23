using System;

class Program
{
    static void Main()
    {
        // Using var (type decided at compile time)
        var number = 10;          // int
        var name = "Payal";       // string

        Console.WriteLine("Var Number: " + number);
        Console.WriteLine("Var Name: " + name);

        // number = "Hello";  // ❌ Not allowed (compile-time error)

        // Using dynamic (type decided at runtime)
        dynamic value = 20;
        Console.WriteLine("Dynamic Value: " + value);

        value = "Hello World";    // Allowed
        Console.WriteLine("Dynamic Changed Value: " + value);

        Console.ReadLine();
    }
}