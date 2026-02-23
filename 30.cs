using System;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("You selected One");
                    break;
                case 2:
                    Console.WriteLine("You selected Two");
                    break;
                case 3:
                    Console.WriteLine("You selected Three");
                    break;
                case 4:
                    Console.WriteLine("You selected Four");
                    break;
                case 5:
                    Console.WriteLine("You selected Five");
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            Console.ReadLine(); // Keeps console open
        }
    }
}