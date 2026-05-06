using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string input = Console.ReadLine();

        if (IsValidUrl(input))
            Console.WriteLine("Valid URL");
        else
            Console.WriteLine("Invalid URL");
    }

    static bool IsValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out Uri result) &&
               (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }
}