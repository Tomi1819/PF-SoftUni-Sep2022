using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            double priceWithoutTax = 0;
            double tax = 0;
            double sumTax = 0;
            double totalPrice = 0;

            while (type != "regular" && type != "special")
            {
                double price = double.Parse(type);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    type = Console.ReadLine();

                }
                else
                {
                    priceWithoutTax = priceWithoutTax + price;
                    tax = 0.2 * price;
                    sumTax = sumTax + tax;
                    totalPrice = totalPrice + (price * 1.2);

                    type = Console.ReadLine();
                }
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");

            }

            else if (type == "special")
            {
                totalPrice = totalPrice * (0.9);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                Console.WriteLine($"Taxes: {sumTax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }

            else if (type == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                Console.WriteLine($"Taxes: {sumTax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");

            }
        }
    }
}
