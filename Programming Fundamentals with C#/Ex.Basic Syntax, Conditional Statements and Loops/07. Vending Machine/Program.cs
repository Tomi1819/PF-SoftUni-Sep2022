using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string product = string.Empty;
            decimal coinSum = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                decimal coins = decimal.Parse(input);
                if (coins == 0.1m)
                {
                    coinSum += coins;
                }
                else if (coins == 0.2m)
                {
                    coinSum += coins;
                }
                else if (coins == 0.5m)
                {
                    coinSum += coins;
                }
                else if (coins == 1.0m)
                {
                    coinSum += coins;
                }
                else if (coins == 2.0m)
                {
                    coinSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    if (coinSum >= 2.0m)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinSum -= 2.0m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (product == "Water")
                {
                    if (coinSum >= 0.7m)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinSum -= 0.7m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (product == "Crisps")
                {
                    if (coinSum >= 1.5m)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinSum -= 1.5m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (product == "Soda")
                {
                    if (coinSum >= 0.8m)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinSum -= 0.8m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (product == "Coke")
                {
                    if (coinSum >= 1.0m)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinSum -= 1.0m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
