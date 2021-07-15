using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas
{
    public class PalindromePairs
    {
        public static int[][] Palindrome(string[] words)
        {
            var result = from word in words
                         from reverseWord in words.Select(word => word
                         .Select(letter => letter)).Select(arrayLetter => string.Concat(arrayLetter.Reverse()))
                         where ( word.Length == reverseWord.Length && word == reverseWord )
                         || (word.Length != reverseWord.Length && word.Contains(reverseWord))
                         select word;

            return new int[][] { };
        }
    }
}
