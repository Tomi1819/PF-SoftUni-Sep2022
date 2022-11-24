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
            var patternName = new Regex(@"(?<name>[A-Za-z]+)");
            string patternDigits = @"(?<digits>\d+)";

            int sumOfDigits = 0;

            Dictionary<string, int> participants = new Dictionary<string, int>();

            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "end of race")
            {
                var matchedNames = patternName.Matches(input);
                var matchedDigits = Regex.Matches(input, patternDigits);

                string currentName = string.Join("", matchedNames);
                string currentDigit = string.Join("", matchedDigits);

                sumOfDigits = 0;

                for (int i = 0; i < currentDigit.Length; i++)
                {
                    sumOfDigits += int.Parse(currentDigit[i].ToString());
                }

                if (names.Contains(currentName))
                {
                    if (!participants.ContainsKey(currentName))
                    {                
                        participants.Add(currentName, sumOfDigits);
                    }
                    participants[currentName] += sumOfDigits;
                }
            }

            var currentWinners = participants
               .OrderByDescending(x => x.Value)
               .Take(3);

            var firstPlace = currentWinners
                .Take(1);

            var secondPlace = currentWinners
                .OrderByDescending(x => x.Value)
                .Take(2)
                .OrderBy(x => x.Value)
                .Take(1);

            var thirdPlace = currentWinners 
                .OrderBy(x => x.Value)
                .Take(1);

            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");

            }

            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }

            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
