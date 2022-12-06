using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmploeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmploeeEfficiency = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int studentPerHour = firstEmploeeEfficiency + secondEmploeeEfficiency + thirdEmploeeEfficiency;

            int hourCounter = 0;
            while (students > 0)
            {
                students -= studentPerHour;
                hourCounter++;
                if (hourCounter % 4 == 0)
                {
                    hourCounter +=1;
                }
            }
            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
