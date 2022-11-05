using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> nums = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (nums.ContainsKey(number))
                {
                    nums[number]++;
                }
                else
                {
                    nums[number] = 1;
                }
            }
            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
