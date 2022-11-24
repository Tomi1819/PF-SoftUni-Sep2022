using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();
            double totalPrice = 0;

            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            string input;
            while ((input = Console.ReadLine())!= "Purchase")
            {
                string[] inputInfo = input.Split();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double singlePrice = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(furnitureName);
                    totalPrice += singlePrice * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitures)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
