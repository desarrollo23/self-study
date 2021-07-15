using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace Katas
{
    public static class PruebasFree
    {
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

        public static List<int> LargestPalindrome()
        {
            var arrayNumbers = new List<int>();

            for (int index = 999; index > 100; index--)
            {
                for (int index2 = 999; index2 > 100; index2--)
                {
                    var mul = index * index2;

                    if (IsPalindrome(mul.ToString()))
                        arrayNumbers.Add(index * index2);
                }
            }

            arrayNumbers.Sort();
            arrayNumbers.Reverse();
            return arrayNumbers.Take(5).ToList();
        }


        public static int[] Fib(int n)
        {
            var arr = new int[n];

            arr[0] = 0;
            arr[1] = 1;

            for (int index = 2; index < n; index++)
            {
                arr[index] = arr[index - 2] + arr[index - 1];
            }

            var evenNumbers = arr.Where(x => x % 2 == 0).ToList();
            evenNumbers.Sort();
            evenNumbers.Reverse();

            return evenNumbers.ToArray();
        }

        public static List<int[]> CompareArrays(int[] array1, int[] array2)
        {
            var lstResult = new List<int[]>();

            var array1Result = array1.Where(x => !array2.Contains(x)).ToArray();
            var array2Result = array2.Where(x => !array1.Contains(x)).ToArray();

            lstResult.Add(array1Result);
            lstResult.Add(array2Result);

            return lstResult;
        }

        public static void SwapVariables()
        {
            var x = 10;
            var y = 20;
            var tmp = x;

            x = y;
            y = tmp;
        }

        public static string UniqueNumbers(string numbers)
        {
            HashSet<int> setNumbers = new HashSet<int>();

            var splittedNumbers = numbers.Split(",");

            foreach (var number in splittedNumbers)
            {
                int.TryParse(number, out int result);
                setNumbers.Add(result);
            }

            return string.Join(",", setNumbers);
        }

        public static IEnumerable<string> CountNumberInstances(string numbers)
        {
            var numbersDictionary = new Dictionary<int, int>();

            var splittedNumbers = numbers.Split(",");

            foreach (var number in splittedNumbers)
            {
                int.TryParse(number, out int result);

                if (!numbersDictionary.ContainsKey(result))
                {
                    numbersDictionary.Add(result, 1);
                    continue;
                }

                numbersDictionary[result]++;
            }

            var response = from numberDictionary in numbersDictionary
                           where numberDictionary.Value % 2 == 0
                           select $"{numberDictionary.Key} appears {numberDictionary.Value} times";

            return response;
        }

        public static int EvaluateExpression(string expression)
        {
            string expr = $"({expression})";
            Queue<int> vals = new Queue<int>();
            Queue<string> ops = new Queue<string>();
            string[] arrayExpression = new string[] { "+", "-", "*", "/"};
            Regex regex = new Regex(@"^[0-9]+$");
            

            var splittedNumbers = expression.Split(arrayExpression, StringSplitOptions.RemoveEmptyEntries);

            //var aaa = expression.Replace(,);
            var splittedOPerations = expression.Split(new string[] { @"^[0-9]+$" }, StringSplitOptions.RemoveEmptyEntries);

            //for (int index = 0; index < expr.Length; index++)
            //{
            //    string character = expr.Substring(index, 1);

            //    if (character.Equals("+") ||
            //        character.Equals("-") ||
            //        character.Equals("*") ||
            //        character.Equals("/"))
            //        ops.Enqueue(character);
            //    else if (character.Equals(")"))
            //    {
            //        int count = ops.Count;
            //        while (count > 0)
            //        {
            //            string operation = ops.Dequeue();
            //            int value = vals.Dequeue();
            //            if (operation.Equals("+")) value = vals.Dequeue() + value;
            //            else if (operation.Equals("-")) value = vals.Dequeue() - value;
            //            else if (operation.Equals("*")) value = vals.Dequeue() * value;
            //            else if (operation.Equals("/")) value = vals.Dequeue() / value;
            //            vals.Enqueue(value);

            //            count--;
            //        }
            //    }
            //    else if (!string.IsNullOrEmpty(character) && !character.Contains(" ") && !character.Equals("("))
            //        vals.Enqueue(int.Parse(character));

            //}

            return vals.Dequeue();


        }

        public static void PrintTriangle()
        {
            var number = 8;
            var count = number - 1;

            for (var index = 1; index <= 8; index++)
            {
                for (var index2 = 1; index2 <= count; index2++)
                    Console.Write(" ");
                count--;

                for (var index2 = 1; index2 <= 2 * index - 1; index2++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }


   

}




