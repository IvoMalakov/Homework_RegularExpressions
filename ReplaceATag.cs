using System;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        Console.WriteLine("Enter a your string here: ");
        string input = Console.ReadLine();

        string pattern = @"(?<tag><a href=(?<link>http:\/\/\w+.\w+)>(?<text>\w+)<\/a>)";
        Match match = Regex.Match(input, pattern);
        string replace = "[URL href=" + match.Groups[2] + "]" + match.Groups[3] + "[/URL]";
        string result = Regex.Replace(input, pattern, replace);
        string quotes = @"""";
        result = Regex.Replace(result, quotes, "");

        Console.WriteLine();
        Console.WriteLine("Your string after the replacement looks like that: ");
        Console.WriteLine();
        Console.WriteLine(result);
    }
}