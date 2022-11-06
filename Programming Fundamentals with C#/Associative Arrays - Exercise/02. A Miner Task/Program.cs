namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string resourse = string.Empty;
            while ((resourse= Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(resourse))
                {
                    dictionary[resourse] = 0;
                }
                dictionary[resourse] += quantity;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
