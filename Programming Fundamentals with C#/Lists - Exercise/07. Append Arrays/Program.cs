using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> numbers = Console.ReadLine()
            //        .Split("|")
            //        .Reverse()
            //        .ToList();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    List<string> newList = numbers[i]
            //        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //        .ToList();
            //    for (int b = 0; b < newList.Count; b++)
            //    {
            //        Console.Write($"{newList[b]} ");
            //    }
            //}

            string[] numbers = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToArray();
            string newArray = string.Join(" ", numbers);
            string[] result = newArray
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
