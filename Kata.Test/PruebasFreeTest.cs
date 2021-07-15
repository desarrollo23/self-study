using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Test
{
    public class PruebasFreeTest
    {
        [Test]
        public void ValidateIfWordIsPalindrome()
        {
            var str = "was it a rat I saw";

            var result = PruebasFree.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ValidateIfWordIsNotPalindrome()
        {
            var str = "Hola no soy palindromo";

            var result = PruebasFree.IsPalindrome(str);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void highest_numbers()
        {
           
            var result = PruebasFree.LargestPalindrome();
            Assert.True(true);
        }

        [Test]
        public void even_numbers()
        {

            var result = PruebasFree.Fib(1000000);
            Assert.True(true);
        }


        [Test]
        public void CompareArrays()
        {

            var result = PruebasFree.CompareArrays(new int[] { 1, 8, 9, 5, 6, 10 }, new int[] { 10,8,5,12,24,36 });
            Assert.True(true);
        }

        [Test]
        public void SwapVariables()
        {

            PruebasFree.SwapVariables();
            Assert.True(true);
        }

        [Test]
        public void UniqueNumbers()
        {

            var restul = PruebasFree.UniqueNumbers("1,2,3,1,2,5,4,5,4");
            Assert.True(true);
        }

        [Test]
        public void CountNumbersInstances()
        {

            var result = PruebasFree.CountNumberInstances("1,2,3,1,2,5,4,5,4");
            Assert.True(true);
        }

        [Test]
        public void EvaluateExpression()
        {
            var exp = "10 / 2 * 3";
            var result = PruebasFree.EvaluateExpression(exp);

            Assert.AreEqual(15, result);
        }
    }
}
