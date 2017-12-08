using System;
using NUnit.Framework;


using CodingKataClassLibrary;
using System.Collections.Generic;

namespace CodingKataTests
{
    [TestFixture]
    public class TestConvertNumbers
    {

        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(5, "five")]
        [TestCase(9,"nine")]
        [TestCase(11, "eleven")]
        [TestCase(14, "fourteen")]
        [TestCase(21, "twenty-one")]
        [TestCase(57, "fifty-seven")]
        [TestCase(48, "fourty-eight")]
        public void ConvertOneDigitNumbers(int number, string numConvertedToString)
        {
            NumbersToWordsConverter converter = new NumbersToWordsConverter();
            Assert.AreEqual(numConvertedToString, converter.ConvertNumber(number));
        }
       

    }
}

