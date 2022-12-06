using System;
using System.Linq;

namespace _06._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    while (lift[i] < 4 && waitingPeople > 0)
                    {
                        lift[i]++;
                        waitingPeople--;
                    }
                }
            }
            if (waitingPeople == 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",lift));
            }
            else if (waitingPeople == 0 && lift.Any(x => x == 4))
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
