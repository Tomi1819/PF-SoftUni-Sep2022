using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelsCount();
        }

        private static void VowelsCount()
        {
            string input = Console.ReadLine().ToLower();
            string[] vowels = new string[] { "a", "e", "i", "o", "u", "y" };
            int count = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (input.Contains(vowels[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
