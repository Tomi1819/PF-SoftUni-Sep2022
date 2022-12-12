using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            List<int> warship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "Retire")
            {
                string[] cmdInfo = comand.Split(" ");
                string type = cmdInfo[0];
                if (type == "Fire")
                {
                    int index = int.Parse(cmdInfo[1]);
                    int damage = int.Parse(cmdInfo[2]);
                    if (index >= 0 && index < warship.Count)
                    {
                        warship[index] -= damage;
                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (type == "Defend")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int endIndex = int.Parse(cmdInfo[2]);
                    int damage = int.Parse(cmdInfo[3]);
                    if ((startIndex >= 0 && startIndex < pirateship.Count) 
                        && (endIndex >= 0 && endIndex < pirateship.Count)
                        && damage >= 0)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateship[i] -= damage;
                            if (pirateship[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (type == "Repair")
                {
                    int index = int.Parse(cmdInfo[1]);
                    int health = int.Parse(cmdInfo[2]);
                    if (index >= 0 && index < pirateship.Count && health >= 0)
                    {
                        pirateship[index] += health;
                        if (pirateship[index] > maxHealth)
                        {
                            pirateship[index] = maxHealth;
                        }
                    }
                }
                else if (type == "Status")
                {
                    int counter = 0;
                    double value = maxHealth - (maxHealth * 0.8);
                    for (int i = 0; i < pirateship.Count; i++)
                    {
                        if (value > pirateship[i])
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateship.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}
