using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];

                if (action == "Add")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Add(value);
                }
                else if (action == "Remove")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.Remove(value);
                }
                else if (action == "RemoveAt")
                {
                    int value = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(value);
                }
                else if (action == "Insert")
                {
                    int value = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, value);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
