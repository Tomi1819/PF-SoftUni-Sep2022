using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousChar = input[0];
            char firstChar = previousChar;
            Console.Write(firstChar);
            for (int i = 1; i < input.Length; i++)
            {
                char currChar = input[i];
                if (previousChar != currChar)
                {
                    previousChar = currChar;
                    Console.Write(previousChar);
                }
            }
        }
    }   
}
