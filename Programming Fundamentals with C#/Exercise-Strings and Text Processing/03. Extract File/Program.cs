using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string cmdInfo = input[input.Length-1];
            string[] splitter = cmdInfo.Split(".");
            string fileName = splitter[0];
            string extension = splitter[1];
            Console.WriteLine($"File name: {fileName} \nFile extension: {extension}");
        }
    }
}
