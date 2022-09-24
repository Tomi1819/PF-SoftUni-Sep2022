using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal count = decimal.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            decimal total = 0;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        total = count * 8.45m;
                    }
                    else if (type == "Business")
                    {
                        total = count * 10.90m;
                    }
                    else if (type == "Regular")
                    {
                        total = count * 15;
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        total = count * 9.80m;
                    }
                    else if (type == "Business")
                    {
                        total = count * 15.60m;
                    }
                    else if (type == "Regular")
                    {
                        total = count * 20;
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        total = count * 10.46m;
                    }
                    else if (type == "Business")
                    {
                        total = count * 16;
                    }
                    else if (type == "Regular") 
                    {
                        total = count * 22.50m;
                    }
                    break;
            }
            
            if (type == "Students" && count >=30)
            {
                total *= 0.85m;
            }
            if (type == "Business" && count >= 100)
            {
                total = total - 10;
            }
            if (type == "Regular" && (count>=10 && count<=20))
            {
                total *= 95;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
