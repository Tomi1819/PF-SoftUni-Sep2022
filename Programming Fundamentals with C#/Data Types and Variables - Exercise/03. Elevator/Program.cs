using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int elevatorCourses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);
            Console.WriteLine(elevatorCourses);
        }
    }
}
