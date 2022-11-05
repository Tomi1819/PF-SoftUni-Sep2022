using System;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }


            //foreach (var word in words)
            //{
            //    if (word.Length % 2 == 0)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

        }
    }
}
