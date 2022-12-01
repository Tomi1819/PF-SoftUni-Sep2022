using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";
            Regex regex = new Regex(pattern);

            BigInteger treshold = 1;
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    int digit = (int)ch - 48;
                    treshold *= digit;
                }
            }

            MatchCollection matchCollection = regex.Matches(input);

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{matchCollection.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in matchCollection)
            {
                string value = match.Groups["emoji"].Value;
                BigInteger coolness = 0;
                foreach (char ch in value)
                {
                    coolness += (int)ch;
                }
                if (coolness>= treshold)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }

        }
    }
}
