using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] commArgs = Console.ReadLine().Split();
                string name = commArgs[0];

                if (commArgs.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if (commArgs.Length == 4)
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestList.Remove(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
