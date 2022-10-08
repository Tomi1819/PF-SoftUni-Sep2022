using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[countOfWagons];
            int sum = 0;
            for (int i = 0; i < countOfWagons; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                Console.Write($"{peopleInWagon[i]} ");
                sum += peopleInWagon[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
