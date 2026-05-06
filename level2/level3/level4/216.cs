using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length;

        Console.Write("Enter password length: ");
        length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Generated Password: " + GeneratePassword(length));
    }

    static string GeneratePassword(int length)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        StringBuilder password = new StringBuilder();
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(chars.Length);
            password.Append(chars[index]);
        }

        return password.ToString();
    }
}