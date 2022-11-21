using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(/|.|-)(?<month>\w{3})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"Day: {match.Groups[2]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
            }
        }
    }
}
