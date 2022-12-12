using System;

namespace _16._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double dayliPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double sumPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                sumPlunder += dayliPlunder;
                if (i % 3 == 0)
                {
                    sumPlunder += dayliPlunder / 2;
                }
                if (i % 5 == 0)
                {
                    sumPlunder *= 0.7;
                }

            }
            if (sumPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sumPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {sumPlunder / expectedPlunder * 100:F2}% of the plunder.");
            }
        }
    }
}
