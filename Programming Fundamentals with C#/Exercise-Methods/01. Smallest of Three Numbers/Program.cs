using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestOfThreeNumbers();
        }

        private static void SmallestOfThreeNumbers()
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallestNumber = Math.Min(Math.Min(firsNumber, secondNumber), thirdNumber);
            Console.WriteLine(smallestNumber);
        }
    }
}
