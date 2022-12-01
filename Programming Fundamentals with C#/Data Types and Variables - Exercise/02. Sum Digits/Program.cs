using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int sum = 0;
            while (integer > 0)
            {
                sum += integer % 10;
                integer /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
