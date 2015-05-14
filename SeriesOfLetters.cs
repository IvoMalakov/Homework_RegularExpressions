using System;
using System.Text.RegularExpressions;

public class SeriesOfLetters
{
    public static void Main()
    {
        Console.WriteLine("Enter a your string here: ");
        Console.WriteLine();
        string input = Console.ReadLine();

        string pattern = @"([a-z]|[A-Z])\1+";
        string replace = "$1";
        string result = Regex.Replace(input, pattern, replace);

        Console.WriteLine("Your string after the replacement looks like that: ");
        Console.WriteLine();
        Console.WriteLine(result);
    }
}