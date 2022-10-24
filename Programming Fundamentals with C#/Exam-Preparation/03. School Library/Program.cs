using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandInfo = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandInfo[0];
                string bookName = commandInfo[1];

                if (commandName == "Add Book")
                {
                    
                }

                command = Console.ReadLine();
            }
        }
    }
}
