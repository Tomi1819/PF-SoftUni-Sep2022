using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(Console.ReadLine());
                numbers[i] = currNum;
            }
            Console.WriteLine(string.Join(' ', numbers)) ;

        }
    }
}
