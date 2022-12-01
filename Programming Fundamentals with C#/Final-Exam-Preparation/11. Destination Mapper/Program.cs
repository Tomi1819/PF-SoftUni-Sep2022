using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();
            string pattern = @"(=|\/)(?<place>[A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matchCollection = regex.Matches(input);

            int sumOfPoints = 0;
            foreach (Match match in matchCollection)
            {
                string place = match.Groups["place"].Value;
                var points = match.Groups["place"].Length;
                destinations.Add(place);
                sumOfPoints += points;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {sumOfPoints}");
        }
    }
}
