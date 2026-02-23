using System;

namespace ConstReadonlyDemo
{
    class Demo
    {
        // Constant variable
        public const double PI = 3.14159;

        // Readonly variable
        public readonly int number;

        // Constructor to initialize readonly variable
        public Demo(int num)
        {
            number = num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo(100);

            Console.WriteLine("Constant Value (PI) = " + Demo.PI);
            Console.WriteLine("Readonly Value = " + obj.number);

            Console.ReadLine(); // Keeps console open
        }
    }
}