using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        { 
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match match in matchCollection)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
