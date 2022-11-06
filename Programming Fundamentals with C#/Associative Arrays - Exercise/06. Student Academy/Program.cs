namespace _06._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsInfo =
                new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(studentName))
                {
                    studentsInfo[studentName] = new List<double>();
                }
                studentsInfo[studentName].Add(grade);

            }
       
            foreach (var kvp in studentsInfo.Where(x => x.Value.Average()>= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
