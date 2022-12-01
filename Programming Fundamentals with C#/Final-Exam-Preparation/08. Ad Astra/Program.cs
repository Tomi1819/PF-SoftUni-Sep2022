using System;
using System.Text.RegularExpressions;

namespace _08._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#||\|)(?<product>[A-Za-z\s]+)(\1)(?<date>\d{2}?\/\d{2}?\/\d{2}?)(\1)(?<calories>\d{1,10000}?)(\1)";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var sumCalories = 0;

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                var calories = (int.Parse)(match.Groups["calories"].Value);
                sumCalories += calories;
            }
            Console.WriteLine($"You have food to last you for: {sumCalories/2000} days!");
            foreach (Match match1 in matchCollection)
            {
                Console.WriteLine($"Item: {match1.Groups["product"].Value}, Best before: {match1.Groups["date"].Value}, Nutrition: {(int.Parse)(match1.Groups["calories"].Value)}");
            }
        }
    }
}
