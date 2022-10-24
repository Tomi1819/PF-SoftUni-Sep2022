using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandInfo = command.Split();
                string commandName = commandInfo[0];
                int index = int.Parse(commandInfo[1]);
                int value = int.Parse(commandInfo[2]);

                if (commandName == "Shoot")
                {
                    if (index>=0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if (commandName == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (commandName == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        targets.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
