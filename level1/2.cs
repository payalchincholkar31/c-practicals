using System;

namespace UserDetailsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking user input
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your City: ");
            string city = Console.ReadLine();

            // Displaying user details
            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);

            Console.ReadLine(); // Keep console open
        }
    }
}