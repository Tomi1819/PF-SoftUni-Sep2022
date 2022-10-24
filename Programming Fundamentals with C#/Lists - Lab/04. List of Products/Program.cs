using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> procucts = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                procucts.Add(product);
            }
            procucts.Sort();

            for (int i = 0; i < procucts.Count; i++)
            {
                Console.WriteLine($"{i+1}.{procucts[i]}");
            }

        }
    }
}
