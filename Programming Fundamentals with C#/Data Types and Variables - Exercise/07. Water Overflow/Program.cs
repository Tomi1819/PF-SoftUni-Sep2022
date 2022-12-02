using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;
            for (int i = 0; i < n; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());
                if ((tank + waterQuantity) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += waterQuantity;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
