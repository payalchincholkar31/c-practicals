using System;

// First part of partial class
partial class Student
{
    public int ID;
    public string Name;

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Student ID: " + ID);
        Console.WriteLine("Student Name: " + Name);
    }
}

// Second part of partial class
partial class Student
{
    public int Marks;

    public void DisplayMarks()
    {
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.ID = 101;
        s.Name = "Payal";
        s.Marks = 85;

        s.DisplayBasicInfo();
        s.DisplayMarks();

        Console.ReadLine();
    }
}