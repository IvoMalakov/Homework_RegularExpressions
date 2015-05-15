using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        Console.WriteLine("Enter your text here: ");
        Console.WriteLine();
        string text = Console.ReadLine();

        string pattern = @"(?<user>[a-z][\w.-]+)@(?<host>[a-z][\w-]+\.[a-z]+)";
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Your text contains the following emails in himself: ");
        Console.WriteLine();

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}