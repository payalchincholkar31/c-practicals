using System;

namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;

            // Arithmetic Operators
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));

            // Relational Operators
            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a >= b: " + (a >= b));
            Console.WriteLine("a <= b: " + (a <= b));

            // Logical Operators
            Console.WriteLine("\nLogical Operators:");
            bool x = true, y = false;
            Console.WriteLine("x && y: " + (x && y));
            Console.WriteLine("x || y: " + (x || y));
            Console.WriteLine("!x: " + (!x));

            // Assignment Operators
            Console.WriteLine("\nAssignment Operators:");
            int c = 10;
            Console.WriteLine("c = " + c);
            c += 5;
            Console.WriteLine("c += 5: " + c);
            c -= 3;
            Console.WriteLine("c -= 3: " + c);
            c *= 2;
            Console.WriteLine("c *= 2: " + c);
            c /= 4;
            Console.WriteLine("c /= 4: " + c);
            c %= 3;
            Console.WriteLine("c %= 3: " + c);

            Console.ReadLine(); // Keeps console open
        }
    }
}