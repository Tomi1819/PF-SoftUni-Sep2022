using System;
using System.Collections.Generic;

namespace _17._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroWithSpells = new Dictionary<string, List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdInfo[0];
                if (cmdType == "Enroll")
                {
                    string heroName = cmdInfo[1];
                    if (!heroWithSpells.ContainsKey(heroName))
                    {
                        heroWithSpells[heroName] = new List<string>() { "",""};
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (cmdType == "Learn")
                {
                    string heroName = cmdInfo[1];
                    string spellName = cmdInfo[2];

                    if (heroWithSpells.ContainsKey(heroName))
                    {
                        heroWithSpells[heroName][0] = spellName;
                        heroWithSpells[heroName].Add(spellName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }

                    if (heroWithSpells.ContainsKey(heroName))
                    {
                        if (!heroWithSpells[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }
                }
                else if (cmdType == "Unlearn")
                {
                    string heroName = cmdInfo[1];
                    string spellName = cmdInfo[2];

                    if (heroWithSpells.ContainsKey(heroName))
                    {
                        heroWithSpells[heroName].Remove(spellName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }

                    if (heroWithSpells.ContainsKey(heroName))
                    {
                        if (!heroWithSpells[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var item in heroWithSpells)
            {
                Console.WriteLine($"== {item.Key}: {item.Value[0]}");
            }
        }
    }
}
