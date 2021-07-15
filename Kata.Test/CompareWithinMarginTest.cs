using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Test
{
    public class CompareWithinMarginTest
    {
        
        [Test]
        public void Validate_CaseIsLower()
        {
            //Arrange
            var a = 4;
            var b = 5;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Validate_CaseIsHigher()
        {
            //Arrange
            var a = 6;
            var b = 5;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Validate_CaseIsCloseToWithMarginZero()
        {
            //Arrange
            var a = 5;
            var b = 5;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Validate_CaseIsLowerWithNegativeNumbers()
        {
            //Arrange
            var a = -6;
            var b = -5;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Validate_CaseIsCloseToWithMarginThree()
        {
            //Arrange
            var a = 2;
            var b = 5;
            var margin = 3;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b, margin);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Validate_CaseIsHigherWithMarginThree()
        {
            //Arrange
            var a = 8.1;
            var b = 5;
            var margin = 3;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b, margin);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Validate_CaseIsLowerWithMarginThree()
        {
            //Arrange
            var a = 1.99;
            var b = 5;
            var margin = 3;

            //Act
            var result = CompareWithinMargin.CloseCompare(a, b, margin);

            //Assert
            Assert.AreEqual(-1, result);
        }




    }
}
