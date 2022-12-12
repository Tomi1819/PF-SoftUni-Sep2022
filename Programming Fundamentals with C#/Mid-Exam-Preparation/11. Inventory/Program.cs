using System;
using System.Collections.Generic;

namespace _11._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materials = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdInfo = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdInfo[0];
                if (type == "Collect")
                {
                    string item = cmdInfo[1];
                    if (!materials.Contains(item))
                    {
                        materials.Add(item);
                    }
                }
                else if (type == "Drop")
                {
                    string item = cmdInfo[1];
                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                    }
                }
                else if (type == "Combine Items")
                {
                    string item = cmdInfo[1];
                    string[] combined = cmdInfo[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = combined[0];
                    string newItem = combined[1];
                    int indexOfOldItem = materials.IndexOf(oldItem);
                    if (materials.Contains(oldItem) && indexOfOldItem >= 0 && indexOfOldItem <= materials.Count)
                    {
                        materials.Insert(indexOfOldItem + 1, newItem);
                    }
                }
                else if (type == "Renew")
                {
                    string item = cmdInfo[1];
                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                        materials.Add(item);    
                    }
                }
            }
            Console.WriteLine(string.Join(", ",materials));
        }
    }
}
