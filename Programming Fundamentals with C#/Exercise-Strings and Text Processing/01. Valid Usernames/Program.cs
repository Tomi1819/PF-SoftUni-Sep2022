using System;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            StringBuilder sb = new StringBuilder();
            foreach (var name in input)
            {
                if (name.Length >= 3 && name.Length<= 16)
                {
                    bool isValid = true;
                    foreach (char ch in name)
                    {
                        if (!(char.IsLetterOrDigit(ch) 
                            || ch == '-' 
                            || ch == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        sb.AppendLine(name);
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
