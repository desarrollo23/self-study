using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;

namespace Katas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var str = "[({()})]";

            //var isValid = ValidBraces.IsValidBraces(str);
            //Console.WriteLine(isValid);

            //var total = StringCalculator.Add("1,2,1001");
            //Console.WriteLine("Total: {0}", total);
            //Console.ReadLine();



            //object obj = new object();
            //string str = "my string";
            //int number = 54;

            //obj.Print("Este es un objeto");
            //str.Print("Este es un string");
            //number.Print("Este es un entero de 32 bits");

            //Random rdn = new Random();
            //List<string> possibleAnswers = new List<string>
            //{
            //    "Si", "No", "Posiblemente", "No lo se", "Definitivamente no", "Definitivamente si"
            //};

            //bool seguirPreguntando = true;


            //while(seguirPreguntando)
            //{
            //    Console.Clear();
            //    Console.Write("Digita tu pregunta: ");
            //    var question = Console.ReadLine();

            //    var index = rdn.Next(possibleAnswers.Count);
            //    var answer = possibleAnswers[index];

            //    Console.WriteLine("La respuesta es: {0}", answer);
            //    Console.Write("Quieres hacer otra pregunta?: ");
            //    var opc = Console.ReadLine();

            //    seguirPreguntando = opc.ToLower().Equals("si");
            //}


            //var result = WeightForWeight.OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123");

            //var result = Diamonds.ReverseWords("yoda doesn't speak like this");
            //Console.WriteLine(result);

            var result = Diamonds.Test("two words");

            Console.ReadLine();
        }

       
        public static int SumSequence(int n)
        {
            if (n == 0) return 0;

            return ReturnMethod();

            int ReturnMethod()
            {
                var numbers = Enumerable.Range(1, n);
                return numbers.Sum();
            }
        }
        public static bool IsPalindrome(string str)
        {
            var replacedStr = str.Replace(" ", "").ToLower();

            List<char> strList = new List<char>();

            foreach (var word in replacedStr)
            {
                if (char.IsWhiteSpace(word))
                    continue;

                strList.Add(word);
            }

            
            strList.Reverse();

            var reversedStr = string.Join("", strList);

            return replacedStr.Equals(reversedStr);
        }
    }

    public static class Util
    {
        public static void Print(this object obj, string message)
        {
            Console.WriteLine($"{obj.GetType()} {message}");
        }
    }


    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
