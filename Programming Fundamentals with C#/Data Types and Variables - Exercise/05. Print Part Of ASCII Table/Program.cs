using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                string currChar = ((char)i).ToString();
                Console.Write($"{currChar} ");
            }
        }
    }
}
