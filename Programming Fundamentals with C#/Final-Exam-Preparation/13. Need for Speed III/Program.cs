using System;
using System.Collections.Generic;

namespace _13._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> carsMileage = new Dictionary<string, double>();
            Dictionary<string, double> carsFuel = new Dictionary<string, double>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split("|");
                string car = carsInfo[0];
                double mileage = double.Parse(carsInfo[1]);
                double fuel = double.Parse(carsInfo[2]);

                carsMileage[car] = mileage;
                carsFuel[car] = fuel;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arg = command.Split(" : ");
                string argType = arg[0];
                if (argType == "Drive")
                {
                    string car = arg[1];
                    double distance = double.Parse(arg[2]);
                    double givenFuel = double.Parse(arg[3]);

                    double fuel = carsFuel[car];
                    if (fuel > givenFuel)
                    {
                        carsMileage[car] += distance;
                        carsFuel[car] -= givenFuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {givenFuel} liters of fuel consumed.");
                        if (carsMileage[car] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carsMileage.Remove(car);
                            carsFuel.Remove(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (argType == "Refuel")
                {
                    string car = arg[1];
                    double fuel = double.Parse(arg[2]);

                    if (carsFuel[car] + fuel > 75)
                    {
                        fuel = 75 - carsFuel[car];
                    }
                    carsFuel[car] += fuel;
                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (argType == "Revert")
                {
                    string car = arg[1];
                    double kilometers = double.Parse(arg[2]);

                    carsMileage[car] -= kilometers;
                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    bool isLess = (carsMileage[car] < 10000);

                    if (isLess)
                    {
                        carsMileage[car] = 10000;
                    }

                }
            }
            foreach (var item in carsMileage)
            {
                string car = item.Key;
                double mileage = item.Value;
                double fuel = carsFuel[car];
                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
