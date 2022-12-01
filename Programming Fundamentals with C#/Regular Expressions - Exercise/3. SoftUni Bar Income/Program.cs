﻿using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\$\.\|]*?\<(?<product>\w+)\>[^\%\$\.\|]*?\|(?<count>\d+)\|[^\%\$\.\|]*?(?<price>\d+(\.\d+)?)\$[^\%\$\.\|]*?$";

            Regex regex = new Regex(pattern);

            double total = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    total += price * count;

                    Console.WriteLine($"{customerName}: {product} - {count*price:f2}");

                }
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
