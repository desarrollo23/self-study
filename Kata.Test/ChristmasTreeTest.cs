using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Test
{
    public class ChristmasTreeTest
    {
        [Test]
        public void ChristmasTreeTest_0()
        {
            Assert.AreEqual("", ChristmasTree.Print(0));
        }

        [Test]
        public void ChristmasTreeTest_1()
        {
            var r = ChristmasTree.Print(1);
            Assert.AreEqual("*", r);
        }

        [Test]
        public void ChristmasTreeTest_2()
        {
            var r = ChristmasTree.Print(2);
            Assert.AreEqual(" * \n***", r);
        }

        [Test]
        public void ChristmasTreeTest_3()
        {
            var r = ChristmasTree.Print(3);
            Assert.AreEqual("  *  \n *** \n*****", r);
        }

        [Test]
        public void ChristmasTreeTest_4()
        {
            var r = ChristmasTree.Print(4);
            Assert.AreEqual("   *   \n  ***  \n ***** \n*******", r);
        }

        [Test]
        public void ChristmasTreeTest_5()
        {
            var r = ChristmasTree.Print(5);
            Assert.AreEqual("    *    \n   ***   \n  *****  \n ******* \n*********", r);
        }
    }
}
