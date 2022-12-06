using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            double average = input.Average();
            List<int> numbers = new List<int>();
            numbers = input
                .OrderByDescending(x => x)
                .Where(x => x > average)
                .Take(5)
                .ToList();

            if (numbers.Count <= 0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
