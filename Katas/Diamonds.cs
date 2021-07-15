using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class Diamonds
    {
        public static string Print(int n)
        {
            if (n <= 0 || n % 2 == 0) return null;

            int middle = n / 2;
            int count = 0;

            StringBuilder str = new StringBuilder();

            var sequence = Enumerable.Range(1, n).ToList();

            foreach (int number in sequence)
            {
                str.Append(' ', Math.Abs(middle - count));
                str.Append('*', n - (Math.Abs(middle - count) * 2));
                str.Append("\n");

                count++;
            }

            return str.ToString();
        }

        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(" ").Reverse());
        }

        public static List<string> Wave(string str)
        {
            var arrayWord = str.Select(x => x.ToString().ToUpper());

            
            int count = 0;
            var list = new List<string>();

            foreach (var letter in arrayWord)
            {
                if(!string.IsNullOrWhiteSpace(letter))
                {
                    var index = str.IndexOf(letter.ToLower(), count);
                    var word = str.Insert(index, letter);

                    var resultWord = word.Remove(count + 1, 1);
                    list.Add(resultWord);
                }

                count++;
            }

            return list;
        }

        public static List<string> Test(string str)
        {
            return str.
                Select((letter, index) => str.Substring(0, index) + Char.ToUpper(letter) + str.Substring(index + 1))
                .Where(x => x != str)
                .ToList();
        }
    }
}
