using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bestModelBeer = string.Empty;
            double biggestBeerKeg = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double currBiggestBeer = Math.PI * radius * radius * height;

                if (currBiggestBeer > biggestBeerKeg)
                {
                    biggestBeerKeg = currBiggestBeer;
                    bestModelBeer = model;
                }
            }
            Console.WriteLine(bestModelBeer);
        }
    }
}
