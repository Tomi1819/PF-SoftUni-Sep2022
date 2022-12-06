using System;

namespace _07._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string info;
            int wins = 0;
            while ((info = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(info);
                if (energy >= distance)
                {
                    energy -= distance;
                    wins++;
                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }
            }
            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
