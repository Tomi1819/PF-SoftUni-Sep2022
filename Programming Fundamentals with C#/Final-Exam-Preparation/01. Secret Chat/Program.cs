using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandInfo = command.Split(":|:");
                string commandName = commandInfo[0];

                if (commandName == "InsertSpace")
                {
                    int index = int.Parse(commandInfo[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (commandName == "Reverse")
                {
                    string substring = commandInfo[1];
                    int index = message.IndexOf(substring);

                    if (index != -1)
                    {
                        message = message.Remove(index, substring.Length);
                        message += string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replacment = commandInfo[2];

                    message = message.Replace(substring, replacment);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
