using System;

class Program
{
    static void Main()
    {
        // Creating a tuple
        Tuple<int, string, double> student =
            new Tuple<int, string, double>(1, "Payal", 85.5);

        Console.WriteLine("Roll No: " + student.Item1);
        Console.WriteLine("Name: " + student.Item2);
        Console.WriteLine("Marks: " + student.Item3);

        Console.ReadLine();
    }
}