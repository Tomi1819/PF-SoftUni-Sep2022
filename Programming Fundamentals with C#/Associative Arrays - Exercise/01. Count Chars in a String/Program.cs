using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!dictionary.ContainsKey(ch))
                    {
                        //dictionary[ch] = 0;
                        dictionary.Add(ch, 0);
                    }
                    dictionary[ch]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
