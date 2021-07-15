using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public static class MyLinq
    {
        public static void Test()
        {
            var people = new List<string> { "Andres", "Pablo", "Erika", "Orlando", "Natalia", "Tulio", "Alvaro", "Andrea" };

            var result = (from person in people
                          where person.ToLower().Contains("o")
                          select person).ToArray();


            var result2 = people.Where(x => x.ToLower().Contains("o"));

            people.Add("Omar");

            var response = people.Filter(x => x.StartsWith("A"));

            foreach (var name in response)
            {
                Console.WriteLine(name);
            }
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
