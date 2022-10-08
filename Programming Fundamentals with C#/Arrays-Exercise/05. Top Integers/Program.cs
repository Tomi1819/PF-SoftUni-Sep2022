using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                bool isTopInteger = true;
                for (int k = i+1; k < numbers.Length; k++)
                {
                    int nextNum = numbers[k];
                    if (nextNum>=currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
