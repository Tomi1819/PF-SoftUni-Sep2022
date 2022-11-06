using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products =
                new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] inputProduct = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string product = inputProduct[0];
                double price = double.Parse(inputProduct[1]);
                double quantity = double.Parse(inputProduct[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = new double[2];
                }
                products[product][0] = price;
                products[product][1] += quantity;
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
