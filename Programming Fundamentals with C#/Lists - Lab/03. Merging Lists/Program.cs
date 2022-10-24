using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int smallerList = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < smallerList; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count > secondList.Count)
            {
                for (int i = smallerList; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            if (secondList.Count > firstList.Count)
            {
                for (int i = smallerList; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
