using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Generating_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            List<int> numbers = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdInfo[0];
                
                if (type == "add")
                {
                    for (int i = 3; i < cmdInfo.Length; i++)
                    {
                        numbers.Insert(i - 3, int.Parse(cmdInfo[i]));
                    }
                }
                else if (type == "replace")
                {
                    int value = int.Parse(cmdInfo[1]);
                    int replacment = int.Parse(cmdInfo[2]);
                    var nestho = numbers.IndexOf(value);
                    numbers.Remove(value);
                    numbers.Insert(nestho, replacment);
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
