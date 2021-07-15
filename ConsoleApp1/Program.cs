using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread cantinero1 = new Thread(new ThreadStart(Cantinero1Atiende));
            //Thread cantinero2 = new Thread(new ThreadStart(Cantinero2Atiende));

            //cantinero1.Start();
            //cantinero2.Start();


            //Console.WriteLine("----------Static constrctor example by vithal wadje------------------");
            //Console.WriteLine();
            //Employee.Salary();

            //var names = new List<string> { "steve", "algosteveaaaaa", "stevens", "danny", "steves", "dan", "john", "johnny", "joe", "alex", "alexander" };
            //var query = new List<string> { "steve", "alex", "joe", "john", "dan" };

            //var result = findCompletePrefixes(names, query);
            //Console.WriteLine(result);
            //Employee.Salary();
            //Console.ReadLine();

            //MyLinq.Test();

            //var del = new Delegates();
            //del.Main("Esto es un mensaje para probar los delegados en c#");

            //del.FunctionsMethod();
            // Data source.

            //int number = 13;
            //var result = IsPrime(number);

            //Console.WriteLine($"Is the number {number} prime?...take a look");
            //Console.WriteLine(result);

            //ArrayList arr = new ArrayList() { "Hola", 23, false, 1.20, "Algo mas" };
            //ArrayList arr2 = new ArrayList() { 1, 23, 3, 19, 5 };

            ArrayList numbers = new ArrayList();
            numbers.Add(50);
            numbers.Add(500);
            numbers.Add(2);
            numbers.Add(150);
            numbers.Add(6);
            numbers.Add(1100);
            numbers.Add(9);
            numbers.Add(1);

            //for (int i = 0; i < numbers.Capacity; i++)
            //{
            //    numbers.Insert(i, i + 1);
            //}

            numbers.Reverse(2, 4);
            numbers.Sort(new MyOwnComparer());

            Stopwatch time = new Stopwatch();

            //time.Start();
            //foreach (object item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //time.Stop();
            //Console.WriteLine("Tiempo1 total: {0}", time.ElapsedMilliseconds);


            time.Start();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            time.Stop();

            Console.WriteLine("Tiempo2 total: {0}", time.ElapsedMilliseconds);

            //ArrayList myAL = new ArrayList(myCollection);
            //myAL.Add("Hello");
            //myAL.Add("World");
            //myAL.Add("!");

            //// Displays the properties and values of the ArrayList.
            //Console.WriteLine("myAL");
            //Console.WriteLine("    Count:    {0}", myAL.Count);
            //Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            //Console.Write("    Values:");
            //PrintValues(myAL);

            //var r = myAL.GetEnumerator();


            int[][] pairArray = PairFunctionClass.PairFunction(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 6);
            string[] stringOuput = pairArray.Select(n => "[" + String.Join(",", n) + "]").ToArray();
            Console.WriteLine(String.Join(",", stringOuput));
            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        public static bool validBraces(String braces)
        {
            return false;
        }

        public static bool IsPrime(int n)
        {
            return Enumerable.Range(2, n - 2).All(x => (n % x) != 0);
        }

        public static string Interpret(string code)
        {
            return (code == "H") ? "Hello World!" : (code == "9") ? BuiltFullLyrics() : (code == "Q") ? code : null;

        }

        public static string BuiltFullLyrics()
        {
            StringBuilder fullLyric = new StringBuilder();

            for (int index = 99; index > 0; index--)
            {
                var nextBottleNumber = (index - 1 == 0) ? "no more bottles" : (index - 1 == 1) ? $"{index - 1} bottle" : $"{index - 1} bottles";
                var currentBottle = (index == 1) ? $"{index} bottle" : $"{index} bottles";

                fullLyric.AppendLine($"{currentBottle} of beer on the wall, {currentBottle} of beer.\nTake one down and pass it around, {nextBottleNumber} of beer on the wall.");
            }

            fullLyric.Append("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");

            return fullLyric.ToString();
        }

        public static List<int> findCompletePrefixes(List<string> names, List<string> query)
        {
            var countMatchPrefix = new List<int>();

            foreach (var prefix in query)
            {
                var namesContainsPrefix = names.Where(name => name.StartsWith(prefix) && !name.Equals(prefix)).ToList();
                countMatchPrefix.Add(namesContainsPrefix.Count);
            }

            //return countMatchPrefix;

            var result = from name in names
                         from prefix in query
                         where name.StartsWith(prefix) && !name.Equals(prefix)
                         group prefix by prefix.Length into prefixCount
                         select prefixCount;

            return new List<int>();
        }

        public static async Task<bool> AsarCarne()
        {
            Console.WriteLine("Mete la carne a asar");

            HttpClient client = new HttpClient();
            await client.GetAsync("https://www.google.com/");

            Console.WriteLine("Saca la carne");

            return true;
        }

        public static async Task FreirPapas()
        {
            Console.WriteLine("Mete las papas a freir");
            HttpClient client = new HttpClient();
            await client.GetAsync("https://www.google.com/");
            Console.WriteLine("Saca las papas");
        }

        public static async Task CalentarArroz()
        {
            Console.WriteLine("Prender la arrocera");
            HttpClient client = new HttpClient();
            await client.GetAsync("https://www.google.com/");
            Console.WriteLine("Apagar la arrocera");
        }

        public static void Cantinero1Atiende()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Cantinero 1 atendiendo al cliente #: " + i);
                Thread.Sleep(1000);
            }

        }

        public static void Cantinero2Atiende()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Cantinero 2 atendiendo al cliente #: " + i);
                Thread.Sleep(1000);
            }

        }


    }

    public class Employee: IComparer
    {
        CaseInsensitiveComparer _comparer = new CaseInsensitiveComparer();
        static Employee()
        {
            Console.WriteLine("The static constructor");
        }

        public static void Salary()
        {
            Console.WriteLine();
            Console.WriteLine("The Salary method");
        }

        public int Compare(object x, object y)
        {
            return _comparer.Compare(x, y);
        }
    }

    public class MyOwnComparer: IComparer
    {
        CaseInsensitiveComparer _comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = _comparer.Compare(y, x);
            return result;
        }
    }

}
