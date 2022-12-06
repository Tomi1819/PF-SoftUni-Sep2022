using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterNames = @"[A-Za-z]";
            string patternNumbers = @"[\d]";

            Dictionary<string, int> players = new Dictionary<string, int>();
            List<string> participants = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                Regex regexName = new Regex(patterNames);
                Regex regexNumber = new Regex(patternNumbers);

                MatchCollection matchedNames = regexName.Matches(input);
                MatchCollection matchedNumbers = regexNumber.Matches(input);

                int km = 0;
                string currName = string.Empty;

                foreach (Match letter in matchedNames)
                {
                    currName += letter.Value;
                }
                foreach (Match digit in matchedNumbers)
                {
                    km += int.Parse(digit.Value);
                }
                if (participants.Contains(currName))
                {
                    if (!players.ContainsKey(currName))
                    {
                        players[currName] = 0;
                    }
                    players[currName] += km;
                }
            }
            Dictionary<string, int> topThree = players
                .OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, v => v.Value);
            int count = 0;
            foreach (var item in topThree)
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine($"{count}st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"{count}nd place: {item.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"{count}rd place: {item.Key}");
                }
            }
        }
    }
}
