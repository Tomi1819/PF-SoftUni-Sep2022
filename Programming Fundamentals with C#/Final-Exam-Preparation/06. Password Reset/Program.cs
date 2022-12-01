using System;
using System.Text;

namespace _06._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commArg = command.Split();
                string commandName = commArg[0];

                if (commandName == "TakeOdd")
                {
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        sb.Append(password[i]);
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (commandName == "Cut")
                {
                    int index = int.Parse(commArg[1]);
                    int lenght = int.Parse(commArg[2]);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (commandName == "Substitute")
                {
                    string subStr = commArg[1];
                    string substitute = commArg[2];

                    if (password.Contains(subStr))
                    {
                        password = password.Replace(subStr, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
