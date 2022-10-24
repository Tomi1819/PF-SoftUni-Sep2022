using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Delete")
                {
                    int value = int.Parse(commandArgs[1]);
                    integers.RemoveAll(x => x == value);
                }
                else if (action == "Insert")
                {
                    int value = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    integers.Insert(index, value);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
