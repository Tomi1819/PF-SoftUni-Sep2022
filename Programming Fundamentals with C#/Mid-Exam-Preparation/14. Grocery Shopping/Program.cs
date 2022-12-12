using System;
using System.Collections.Generic;

namespace _14._Grocery_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>(Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries));
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Shop!")
            {
                string[] cmdInfo = command.Split("%");
                string type = cmdInfo[0];
                if (type == "Important")
                {
                    string product = cmdInfo[1];
                    if (product.Contains(product))
                    {
                        products.Remove(product);
                        products.Insert(0, product);
                    }
                    else
                    {
                        products.Insert(0, product);
                    }
                }
                else if (type == "Add")
                {
                    string product = cmdInfo[1];
                    if (!products.Contains(product))
                    {
                        products.Add(product);
                    }
                    else
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                }
                else if (type == "Swap")
                {
                    string productOne = cmdInfo[1];
                    string productTwo = cmdInfo[2];
                    if (products.Contains(productOne)  && !products.Contains(productTwo))
                    {
                        Console.WriteLine($"Product {productTwo} missing!");
                    }
                    else if (!products.Contains(productOne) && products.Contains(productTwo))
                    {
                        Console.WriteLine($"Product {productOne} missing!");
                    }
                    else
                    {
                        int indexOne = products.IndexOf(productOne);
                        int indexTwo = products.IndexOf(productTwo);
                        var temp = products[indexOne];
                        products[indexOne] = products[indexTwo];
                        products[indexTwo] = temp;
                    }
                }
                else if (type == "Remove")
                {
                    string product = cmdInfo[1];
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                    else
                    {
                        Console.WriteLine($"Product {product} isn't in the list.");
                    }
                }
                else if (type == "Reversed")
                {
                    products.Reverse();
                }
            }
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
        }
    }
}
