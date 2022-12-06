using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int countOfMoves = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                countOfMoves++;

                string[] indexes = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int firstElement = int.Parse(indexes[0]);
                int secondElement = int.Parse(indexes[1]);

                if (firstElement >= 0 && secondElement >= 0 
                    && firstElement < input.Count 
                    && secondElement < input.Count 
                    && firstElement != secondElement)
                {
                    if (input[firstElement] == input[secondElement])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[firstElement]}!");

                        if (firstElement > secondElement)
                        {
                            input.RemoveAt(firstElement);
                            input.RemoveAt(secondElement);
                        }
                        else
                        {
                            input.RemoveAt(secondElement);
                            input.RemoveAt(firstElement);
                        }
                        if (input.Count == 0)
                        {
                            Console.WriteLine($"You have won in {countOfMoves} turns!");
                            return;
                        }
                    }
                    else if (input[firstElement] != input[secondElement])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    input.Insert(input.Count / 2, $"-{countOfMoves}a");
                    input.Insert(input.Count / 2, $"-{countOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
