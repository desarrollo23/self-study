using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Test
{
    public class RomanNumeralsDecoderTest
    {
        #region Main numbers
        [Test]
        public void TestPassing_I_ShouldReturn_1()
        {
            var romanNumber = "I";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestPassing_V_ShouldReturn_5()
        {
            var romanNumber = "V";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestPassing_X_ShouldReturn_10()
        {
            var romanNumber = "X";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void TestPassing_L_ShouldReturn_50()
        {
            var romanNumber = "L";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(50, result);
        }

        [Test]
        public void TestPassing_C_ShouldReturn_100()
        {
            var romanNumber = "C";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(100, result);
        }

        [Test]
        public void TestPassing_D_ShouldReturn_500()
        {
            var romanNumber = "D";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(500, result);
        }

        [Test]
        public void TestPassing_M_ShouldReturn_1000()
        {
            var romanNumber = "M";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(1000, result);
        }

        #endregion

        #region Substring numbers
        [Test]
        public void TestPassing_IV_ShouldReturn_4()
        {
            var romanNumber = "IV";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestPassing_IX_ShouldReturn_9()
        {
            var romanNumber = "IX";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(9, result);
        }

        [Test]
        public void TestPassing_XIV_ShouldReturn_14()
        {
            var romanNumber = "XIV";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(14, result);
        }

        [Test]
        public void TestPassing_LIV_ShouldReturn_54()
        {
            var romanNumber = "LIV";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(54, result);
        }

        [Test]
        public void TestPassing_LIX_ShouldReturn_59()
        {
            var romanNumber = "LIX";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(59, result);
        }
        #endregion

        #region Big Numbers

        [Test]
        public void TestPassing_MCMXC_ShouldReturn_1990()
        {
            var romanNumber = "MCMXC";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(1990, result);
        }

        [Test]
        public void TestPassing_MMVIII_ShouldReturn_2008()
        {
            var romanNumber = "MMVIII";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(2008, result);
        }

        [Test]
        public void TestPassing_MDCLXVI_ShouldReturn_1666()
        {
            var romanNumber = "MDCLXVI";

            var result = RomanNumeralsDecoder.Solution(romanNumber);

            Assert.AreEqual(1666, result);
        }
        #endregion

    }
}
