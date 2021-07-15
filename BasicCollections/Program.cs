using System;
using System.Collections;

namespace BasicCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("First");
            arr.Add("Second");
            arr.Add("Third");
            arr.Add("Fourth");

            Console.WriteLine("Iterate original array:");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<>>>>>>>>>>");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Sort();

            Console.WriteLine();
            Console.WriteLine("Iterate order array:");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<>>>>>>>>>>");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
