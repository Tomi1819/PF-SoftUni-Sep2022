﻿using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            for (int row = 1; row <=n; row++)
            {
                if (type == "Isosceles")
                {
                    int spacesCnt = n - row;
                    for (int spaces = 1; spaces <= spacesCnt; spaces++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int col = 1; col <=row; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
        }
    }
}
