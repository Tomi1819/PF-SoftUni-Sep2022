namespace _04._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary =
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string command = cmdInfo[0];
                string username = cmdInfo[1];
                if (command == "register")
                {
                    string licensePlateNumber = cmdInfo[2];
                    if (!dictionary.ContainsKey(username))
                    {
                        dictionary[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        string registredNumber = dictionary[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registredNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!dictionary.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        dictionary.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
