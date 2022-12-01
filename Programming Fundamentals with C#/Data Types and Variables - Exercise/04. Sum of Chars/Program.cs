using System;
using System.Globalization;
using System.Linq;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();
                int asci = letter.ElementAt(0);
                sum += asci;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
