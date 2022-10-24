using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "swap")
                {
                    SwapMethod(array, commandArgs);
                }
                else if (commandArgs[0] == "multiply")
                {
                    MultiplyMethod(array, commandArgs);
                }
                else if (commandArgs[0] == "decrease")
                {
                    DecreaseMethod(array, commandArgs);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
        private static void SwapMethod(int[] array, string[] commandArgs)
        {
            int firstIndex = int.Parse(commandArgs[1]);
            int secondIndex = int.Parse(commandArgs[2]);

            int curr = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = curr;
        }
        private static void MultiplyMethod(int[] array, string[] commandArgs)
        {
            int firstIndex = int.Parse(commandArgs[1]);
            int secondIndex = int.Parse(commandArgs[2]);

            array[firstIndex] = array[firstIndex] * array[secondIndex];
        }
        private static void DecreaseMethod(int[] array, string[] commandArgs)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }
        }
    }
}
