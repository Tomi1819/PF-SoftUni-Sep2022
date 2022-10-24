using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArg = command.Split();
                string action = commandArg[0];

                if (action == "Add")
                {
                    int value = int.Parse(commandArg[1]);
                    listOfWagons.Add(value);
                }
                else
                {
                    int numberOfPassenger = int.Parse(commandArg[0]);
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + numberOfPassenger <= maxCapacity)
                        {
                            listOfWagons[i] += numberOfPassenger;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}
