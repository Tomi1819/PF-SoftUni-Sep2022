﻿using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nCopy = n;
            int sum = 0;

            while (n > 0)
            {
                var factoriel = 1;
                var number = n % 10;
                n /= 10;

                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }
            if (sum == nCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
