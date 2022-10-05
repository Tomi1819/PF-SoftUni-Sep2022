using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = new int[arr1.Length - 1];

        if (arr1.Length == 1)
        {
            Console.WriteLine(arr1[0]);
            return;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length - i; j++)
            {
                arr2[j] = arr1[j] + arr1[j + 1];
            }
            arr1 = arr2;
        }
        Console.WriteLine(arr2[0]);
    }
}
