using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pairs = new List<string>();
            string input = Console.ReadLine();
            string pattern = @"(@|#)(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                pairs.Add(match.ToString());
            }
            // To be continued..........

        }
    }
}
