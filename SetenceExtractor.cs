using System;
using System.Text.RegularExpressions;

public class SetenceExtractor
{
    public static void Main()
    {
        Console.WriteLine("Enter your keyword here: ");
        string keyword = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Enter your text here: ");
        Console.WriteLine();
        string text = Console.ReadLine();

        string pattern = @"[A-Z][\w\W]*?\b" + keyword + @"\b[\w\W]*?[.!?]";
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Your text contains the following setences in himself: ");
        Console.WriteLine();

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}