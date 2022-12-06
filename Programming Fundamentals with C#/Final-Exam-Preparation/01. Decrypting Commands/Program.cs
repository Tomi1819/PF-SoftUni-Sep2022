using System;

namespace _01._Decrypting_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] cmdInfo = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdInfo[0];
                if (cmdType == "Replace")
                {
                    string currentChar = cmdInfo[1];
                    string newChar = cmdInfo[2];
                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (cmdType == "Cut")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int endIndex = int.Parse(cmdInfo[2]);
                    if (startIndex >= 0 && endIndex < message.Length)
                    {
                        message = message.Remove(startIndex, endIndex);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (cmdType == "Make")
                {
                    string upperOrLower = cmdInfo[1];
                    if (upperOrLower == "Upper")
                    {
                        message = message.ToUpper();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        message = message.ToLower();
                        Console.WriteLine(message);
                    }
                }
                else if (cmdType == "Check")
                {
                    string str = cmdInfo[1];
                    if (message.Contains(str))
                    {
                        Console.WriteLine($"Message contains {str}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {str}");
                    }
                }
                else if (cmdType == "Sum")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int endIndex = int.Parse(cmdInfo[2]);
                    int sum = 0;
                    if (startIndex >= 0 && endIndex < message.Length)
                    {
                        string subStr = message.Substring(startIndex, endIndex);
                        for (int i = 0; i < subStr.Length; i++)
                        {
                            sum += subStr[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }
    }
}
