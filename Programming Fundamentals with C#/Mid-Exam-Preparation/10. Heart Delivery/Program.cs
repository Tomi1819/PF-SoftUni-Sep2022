using System;
using System.Linq;

namespace _10._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lastPosition = 0;
            int success = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int length = int.Parse(cmdInfo[1]);
                lastPosition += length;
                if (lastPosition < 0 || lastPosition >= input.Length)
                {
                    lastPosition = 0;
                }
                if (input[lastPosition] != 0)
                {
                    input[lastPosition] -= 2;
                    if (input[lastPosition] == 0)
                    {
                        success++;
                        Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (success == input.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {input.Length - success} places.");
            }
        }
    }
}
