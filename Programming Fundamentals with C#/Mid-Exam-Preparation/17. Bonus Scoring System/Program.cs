using System;

namespace _17._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudent = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxAttendence = 0;

            for (int i = 1; i <= numberOfStudent; i++)
            {
                double currAttendence = double.Parse(Console.ReadLine());
                double currBonus = (currAttendence / numberOfLectures) * (5 + additionalBonus);
                if (currBonus > maxBonus)
                {
                    maxBonus = currBonus;
                    maxAttendence = currAttendence;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendence} lectures.");
        }
    }
}
