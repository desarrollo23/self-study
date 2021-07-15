using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Test
{
    public class PalindromePairsTest
    {
        [Test]
        public void Test_PassingTwoExactWords_ShouldReturn_ArrayWihtTwoIndexes()
        {
            var words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            var resultExpected = new int[2][];
            resultExpected[0] = new int[] { 0, 1 };
            resultExpected[1] = new int[] { 1, 0 };

            var result = PalindromePairs.Palindrome(words);

            Assert.AreEqual(resultExpected, result);
        }
    }
}
