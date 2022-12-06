using System;
using System.Linq;

namespace _08._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string info = string.Empty;
            int count = 0;
            while ((info = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(info);
                if (targetIndex >= 0 && targetIndex < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int curr = targets[targetIndex];
                        if (targets[i] != -1 && i != targetIndex)
                        {
                            if (targets[i] > curr)
                            {
                                targets[i] -= curr;
                            }
                            else
                            {
                                targets[i] += curr;
                            }
                        }
                    }
                    targets[targetIndex] = -1;
                    count++;
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
