using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pairsWords = new Dictionary<string, string>();
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();
            string pattern = @"(@|#)(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                string wordOne = match.Groups["wordOne"].Value;
                string wordTwo = match.Groups["wordTwo"].Value;

                pairsWords.Add(wordOne, wordTwo);
                string reversedWord = string.Empty;
                for (int i = wordTwo.Length - 1; i >= 0; i--)
                {
                    reversedWord += wordTwo[i];
                }
                if (reversedWord == wordOne)
                {
                    mirrorWords.Add(wordOne, wordTwo);
                }
            }
            if (pairsWords.Count <= 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairsWords.Count} word pairs found!");
            }
            if (mirrorWords.Count <= 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}
