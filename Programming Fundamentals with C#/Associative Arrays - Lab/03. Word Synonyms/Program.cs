using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, new List<string>());
                }
                dictionary[key].Add(value);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
