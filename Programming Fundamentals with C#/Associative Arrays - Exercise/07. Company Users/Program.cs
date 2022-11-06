namespace _07._Company_Users
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInfo =
                new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = input.Split(" -> ");
                string companyName = cmdInfo[0];
                string employee = cmdInfo[1];

                if (!companyInfo.ContainsKey(companyName))
                {
                    companyInfo[companyName] = new List<string>();
                }
                if (!companyInfo[companyName].Contains(employee))
                {
                    companyInfo[companyName].Add(employee);
                }

            }
            foreach (var item in companyInfo)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var values in item.Value)
                {
                    Console.WriteLine($"-- {values}");
                }
            }
        }
    }
}
