using System;

class Student
{
    public string name;
    public int age;

    // Constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object and calling constructor
        Student s1 = new Student("Payal", 20);

        s1.Display();

        Console.ReadLine();
    }
}