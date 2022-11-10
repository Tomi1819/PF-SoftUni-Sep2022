using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder nums = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsDigit(ch))
                {
                    nums.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(others);

        }
    }
}
