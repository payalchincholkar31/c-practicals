using System;

class Program
{
    // Declaring struct
    struct Student
    {
        public int rollNo;
        public string name;
        public double marks;

        public void Display()
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
    }

    static void Main()
    {
        Student s1;   // Creating struct object

        s1.rollNo = 1;
        s1.name = "Payal";
        s1.marks = 85.5;

        s1.Display();

        Console.ReadLine();
    }
}