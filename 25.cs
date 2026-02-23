using System;

namespace AsciiValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            int asciiValue = (int)ch;

            Console.WriteLine("ASCII value of " + ch + " is: " + asciiValue);

            Console.ReadLine(); // Keeps console open
        }
    }
}