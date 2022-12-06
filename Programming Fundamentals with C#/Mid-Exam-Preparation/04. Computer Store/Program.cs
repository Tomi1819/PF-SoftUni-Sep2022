using System;

namespace _04._Computer_Store
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
                    priceWithoutTax += price;
                    tax = price * 0.2;
                    sumTax += tax;
                    totalPrice += (price * 1.2);
                    type = Console.ReadLine();
                }
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;

            }

            if (type == "special")
            {
                totalPrice = totalPrice * (0.9);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                Console.WriteLine($"Taxes: {sumTax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }
            else
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
