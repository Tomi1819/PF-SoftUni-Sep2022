namespace _05._Courses
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> couseInfo =
                new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdInfo = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdInfo[0];
                string studentName = cmdInfo[1];
                if (!couseInfo.ContainsKey(courseName))
                {
                    couseInfo[courseName] = new List<string>();
                }
                couseInfo[courseName].Add(studentName);
            }
            foreach (var kvp in couseInfo)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
