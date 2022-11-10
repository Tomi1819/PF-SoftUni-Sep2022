using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "end")
            {
                var reversed = word.ToArray().Reverse();
                Console.WriteLine($"{word} = {string.Join("", reversed)}");
            }
        }
    }
}
