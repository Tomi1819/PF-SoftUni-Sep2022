using System;
using System.Collections.Generic;

namespace _05._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroHp = new Dictionary<string, int>();
            Dictionary<string, int> heroMp = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = commArgs[0];
                int hitPoints = int.Parse(commArgs[1]);
                int manaPoints = int.Parse(commArgs[2]);

                if (!heroHp.ContainsKey(heroName))
                {
                    if (hitPoints<= 100)
                    {
                        heroHp[heroName] = hitPoints;
                    }
                    else if (hitPoints>100)
                    {
                        heroHp[heroName] = 100;
                    }
                }
                if (!heroMp.ContainsKey(heroName))
                {
                    if (manaPoints <= 200)
                    {
                        heroMp[heroName] = manaPoints;
                    }
                    else if (manaPoints > 200)
                    {
                        heroMp[heroName] = 200;
                    }
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string commandName = cmdArg[0];
                string heroName = cmdArg[1];

                if (commandName == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if (heroMp[heroName] >= mpNeeded)
                    {
                        double difference = heroMp[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {difference} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandName == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];
                    heroHp[heroName] -= damage;
                    if (heroHp[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroHp.Remove(heroName);
                        heroMp.Remove(heroName);
                    }
                }
                else if (commandName == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);
                    if (heroMp[heroName] + amount  > 200)
                    {
                        amount = 200 - heroMp[heroName];
                    }
                    heroMp[heroName] += amount;
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (commandName == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);
                    if (heroHp[heroName] + amount > 100)
                    {
                        amount = 100 - heroHp[heroName];
                    }
                    heroHp[heroName] += amount;
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }
            foreach (var kvp in heroMp)
            {
                string heroName = kvp.Key;
                int mana = kvp.Value;
                int healthPoints = heroHp[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {healthPoints}");
                Console.WriteLine($"  MP: {mana}");
            }
        }
    }
}
