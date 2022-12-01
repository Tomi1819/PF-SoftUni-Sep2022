using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> townPopulation = new Dictionary<string, int>();
            Dictionary<string, int> townGold = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cmdInfo = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = cmdInfo[0];
                int population = int.Parse(cmdInfo[1]);
                int gold = int.Parse(cmdInfo[2]);

                if (!townPopulation.ContainsKey(town))
                {
                    townPopulation[town] = population;
                    townGold[town] = gold;
                }
                else
                {
                    townPopulation[town] += population;
                    townGold[town] += gold;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdInfo[0];

                if (cmdType == "Plunder")
                {
                    string town = cmdInfo[1];
                    int population = int.Parse(cmdInfo[2]);
                    int gold = int.Parse(cmdInfo[3]);

                    townPopulation[town] -= population;
                    townGold[town] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (townPopulation[town] <= 0 || townGold[town] <= 0)
                    {
                        townPopulation.Remove(town);
                        townGold.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (cmdType == "Prosper")
                {
                    string town = cmdInfo[1];
                    int gold = int.Parse(cmdInfo[2]);
                    if (gold >= 0)
                    {
                        townGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townGold[town]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
            }
            if (townGold.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {townGold.Count} wealthy settlements to go to:");
            }
            foreach (var kvp in townPopulation)
            {
                string town = kvp.Key;
                int population = kvp.Value;
                int gold = townGold[town];
                Console.WriteLine($"{town} -> Population: {population} citizens, Gold: {gold} kg");

            }
        }
    }
}
