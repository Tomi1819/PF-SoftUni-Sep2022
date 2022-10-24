using System;

namespace _01._The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfBiscutsForWorker = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double numberOfBiscuitsForThirtyDays = double.Parse(Console.ReadLine());
            double totalBiscuits = 0;




            for (int i = 1; i <= 30; i++)
            {
                double sumOfBiscuits = numberOfBiscutsForWorker * countOfWorkers;
                totalBiscuits += sumOfBiscuits;
                if (i % 3 == 0)
                {
                    totalBiscuits -= sumOfBiscuits * 0.25;
                }

            }
            double difference = totalBiscuits - numberOfBiscuitsForThirtyDays;
            double percent = difference / numberOfBiscuitsForThirtyDays * 100;
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            if (totalBiscuits >= numberOfBiscuitsForThirtyDays)
            {
                Console.WriteLine($"You produce {Math.Abs(percent):f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(percent):f2} percent less biscuits.");
            }
        }
    }
}
