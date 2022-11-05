using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();
                if (counts.ContainsKey(lowerWord))
                {
                    counts[lowerWord]++;
                }
                else
                {
                    counts.Add(lowerWord, 1);
                }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
