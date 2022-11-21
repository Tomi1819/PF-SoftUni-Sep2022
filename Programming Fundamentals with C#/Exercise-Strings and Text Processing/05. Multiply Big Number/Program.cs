using System;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();




            //BigInteger a = BigInteger.Parse(Console.ReadLine());
            //BigInteger b = BigInteger.Parse(Console.ReadLine());
            //stopwatch.Start();
            //Console.WriteLine(a * b);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);



            string input = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());
            stopwatch.Start();
            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            if (multiplyer == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDig = int.Parse(input[i].ToString());
                int total = (currDig * multiplyer) + reminder;
                int result = total % 10;
                reminder = total / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
            stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
