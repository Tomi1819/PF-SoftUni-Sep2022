namespace _04._Activation_Keys
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder rawActivationKey = new StringBuilder(Console.ReadLine());

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandInfo = command.Split(">>>");

                string commandName = commandInfo[0];

                if (commandName == "Contains")
                {
                    string substring = commandInfo[1];
                    if (rawActivationKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandName == "Flip")
                {
                    string upperOrLower = commandInfo[1];

                    int startIndex = int.Parse(commandInfo[2]);
                    int endIndex = int.Parse(commandInfo[3]);

                    string substring = rawActivationKey.ToString().Substring(startIndex, endIndex - startIndex);
                    if (upperOrLower == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else
                    {
                        substring = substring.ToLower();
                    }

                    rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey.Insert(startIndex, substring);
                    Console.WriteLine(rawActivationKey);
                }
                else if (commandName == "Slice")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
