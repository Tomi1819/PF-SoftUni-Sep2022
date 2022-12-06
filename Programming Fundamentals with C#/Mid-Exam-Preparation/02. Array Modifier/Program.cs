using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty.ToLower();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdInfo[0] == "swap")
                {
                    int firstIndex = int.Parse(cmdInfo[1]);
                    int secondIndex = int.Parse(cmdInfo[2]);

                    int curr = array[firstIndex];
                    array[firstIndex] = array[secondIndex];
                    array[secondIndex] = curr;
                }
                else if (cmdInfo[0] == "multiply")
                {
                    int firstIndex = int.Parse(cmdInfo[1]);
                    int secondIndex = int.Parse(cmdInfo[2]);

                    array[firstIndex] = array[firstIndex] * array[secondIndex];
                }
                else if (cmdInfo[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i]--;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
