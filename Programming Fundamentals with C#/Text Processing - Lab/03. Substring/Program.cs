using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();

            while (stringTwo.Contains(stringOne))
            {
                int startIndex = stringTwo.IndexOf(stringOne);
                stringTwo = stringTwo.Remove(startIndex, stringOne.Length);
            }
            Console.WriteLine(stringTwo);
        }
    }
}
