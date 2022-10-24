using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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

            bool isChecked = false;

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];

                if (action == "Add")
                {
                    isChecked = true;
                    int value = int.Parse(commandArgs[1]);
                    numbers.Add(value);
                }
                else if (action == "Remove")
                {
                    isChecked = true;
                    int value = int.Parse(commandArgs[1]);
                    numbers.Remove(value);
                }
                else if (action == "RemoveAt")
                {
                    isChecked = true;
                    int value = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(value);
                }
                else if (action == "Insert")
                {
                    isChecked = true;
                    int value = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, value);
                }
                else if (action == "Contains")
                {
                    int value = int.Parse(commandArgs[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (action == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(string.Join(" ",numbers.Sum()));
                }
                else if (action == "Filter")
                {
                    string condition = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number )));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }

                }

                command = Console.ReadLine();
            }
            if (isChecked)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
