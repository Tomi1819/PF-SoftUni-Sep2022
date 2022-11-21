using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = null;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                letter += (char)3;
                encrypted += letter;
            }
            Console.WriteLine(encrypted);
        }
    }
}
