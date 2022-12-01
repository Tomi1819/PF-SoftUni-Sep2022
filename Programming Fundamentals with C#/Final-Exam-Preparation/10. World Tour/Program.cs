using System;
using System.Text;

namespace _10._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cdInfo = command.Split(":");
                string action = cdInfo[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(cdInfo[1]);
                    string str = cdInfo[2];

                    if (index >= 0 && index < sb.Length)
                    {
                        sb.Insert(index, str);
                    }
                    Console.WriteLine(sb);

                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(cdInfo[1]);
                    int endIndex = int.Parse(cdInfo[2]);

                    if (startIndex >= 0)
                    {
                        if (endIndex < sb.Length)
                        {
                            sb.Remove(startIndex, (endIndex - startIndex + 1));
                        }
                    }
                    Console.WriteLine(sb);
                }
                else if (action == "Switch")
                {
                    string oldString = cdInfo[1];
                    string newString = cdInfo[2];

                    sb.Replace(oldString, newString);
                    Console.WriteLine(sb);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}
