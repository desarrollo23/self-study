using Katas;
using NUnit.Framework;
using System;

namespace Kata.Test
{
    public class StringCalculatorKata
    {
        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }


        [Test]
        public void Add_StringContainingSingleNumber_ReturnsItSelf()
        {
            Assert.AreEqual(5, StringCalculator.Add("5"));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            Assert.AreEqual(10, StringCalculator.Add("2,8"));
        }

        [Test]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            Assert.AreEqual(20, StringCalculator.Add("2,8,10"));
        }

        [TestCase("1,2,3,4",10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 9)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(string input, int resul)
        {
            Assert.AreEqual(resul, StringCalculator.Add(input));
        }

        [TestCase("1,2,3,4,5, -5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Add_StringContainingNegativeNumber_ReturnsException(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }
    }
}