using System;

namespace _13._Gift_Box_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            double paperSheets = double.Parse(Console.ReadLine());
            double area = (sizeOfSide * sizeOfSide) * 6;
            double used = 0;

            for (int i = 1; i <= paperSheets; i++)
            {
                double paperLenght = double.Parse(Console.ReadLine());
                double paperWidth = double.Parse(Console.ReadLine());
                double singleSheet = paperLenght * paperWidth;
                if (i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0)
                {
                    used += (singleSheet * 0.75);
                    continue;
                }
                else
                {
                    used += singleSheet;
                }
            }
            double covered = (used / area) * 100;
            double paperLeft = (used - area);
            double percentage = (paperLeft / used) * 100;
            if (used >= area)
            {
                Console.WriteLine($"You've covered the gift box!");
                Console.WriteLine($"{percentage:f2}% wrap paper left.");
            }
            else
            {
                Console.WriteLine($"You are out of paper!");
                Console.WriteLine($"{100 - covered:f2}% of the box is not covered.");
            }
        }
    }
}
