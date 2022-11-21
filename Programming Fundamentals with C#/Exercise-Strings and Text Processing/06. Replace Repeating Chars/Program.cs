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
            //List<string> input = Console.ReadLine().Split().ToList();
            //List<string> output = new List<string>();
            //foreach (var ch in input)
            //{
            //    if (!output.Contains(ch))
            //    {
            //        output.Add(ch);
            //    }
            //}
            //Console.WriteLine(string.Join("",output));


            //string input = Console.ReadLine();
            //string output = string.Empty;
            //foreach (var ch in input)
            //{
            //    if (!output.Contains(ch))
            //    {
            //        output += ch;
            //    }
            //}
            //Console.WriteLine(output);




            string text = Console.ReadLine();
            char previousChar = text[0];
            Console.Write(previousChar);
            for (int i = 1; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (previousChar != currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }   
}
