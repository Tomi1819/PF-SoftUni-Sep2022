using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = inputInfo[0];
                int rarity = int.Parse(inputInfo[1]);

                if (!plantRarity.ContainsKey(plantName))
                {
                    plantRarity[plantName] = rarity;
                    plantRating[plantName] = new List<double>();
                }
                else
                {
                    plantRarity[plantName] = rarity;
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commArg = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string commName = commArg[0];
                string currPlantName = commArg[1];
                AllFunctions(plantRarity, plantRating, commArg, commName, currPlantName);
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var (currPlantName, rarity) in plantRarity)
            {
                double average = plantRating[currPlantName].Count > 0
                    ? plantRating[currPlantName].Average()
                    : 0;
                Console.WriteLine($"- {currPlantName}; Rarity: {rarity}; Rating: {average:f2}");
            }
        }

        private static void AllFunctions(Dictionary<string, int> plantRarity, Dictionary<string, List<double>> plantRating, string[] commArg, string commName, string currPlantName)
        {
            if (commName == "Rate")
            {
                RateMethod(plantRating, commArg, currPlantName);
            }
            else if (commName == "Update")
            {
                UpdateMethod(plantRarity, commArg, currPlantName);
            }
            else if (commName == "Reset")
            {
                ResetMethod(plantRating, currPlantName);
            }
        }

        private static void ResetMethod(Dictionary<string, List<double>> plantRating, string currPlantName)
        {
            if (plantRating.ContainsKey(currPlantName))
            {
                plantRating[currPlantName].Clear();
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void UpdateMethod(Dictionary<string, int> plantRarity, string[] commArg, string currPlantName)
        {
            int rarity = int.Parse(commArg[2]);
            if (plantRarity.ContainsKey(currPlantName))
            {
                plantRarity[currPlantName] = rarity;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void RateMethod(Dictionary<string, List<double>> plantRating, string[] commArg, string currPlantName)
        {
            int currPlantRating = int.Parse(commArg[2]);

            if (plantRating.ContainsKey(currPlantName))
            {
                plantRating[currPlantName].Add(currPlantRating);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
