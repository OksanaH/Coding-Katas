using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingKataClassLibrary;
using NUnit.Framework;

namespace CodingKataTests
{
    [TestFixture]
    public class EulerProject_Exercise17
    {
        //https://projecteuler.net/problem=17
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(3, "three")]
        [TestCase(10, "ten")]
        [TestCase(19, "nineteen")]
        public void Verify_YouCanGet_Number0To19_InWords(int number, string expected)
        {
            LettersCount lc = new LettersCount();
            string actual = lc.GetNumberInWords(number);
            Assert.AreEqual(expected,actual);            
        }
        
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(50, "fifty")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]
        public void Verify_YouCanGet_MultiplesOf10_InWords(int number, string expected)
        {
            LettersCount lc = new LettersCount();
            string actual = lc.GetNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(21, "twenty-one")]
        [TestCase(44, "fourty-four")]
        [TestCase(89, "eighty-nine")]
        [TestCase(67, "sixty-seven")]
        [TestCase(99, "ninety-nine")]
        public void Verify_YouCanGet_21To99_InWords(int number, string expected)
        {
            LettersCount lc = new LettersCount();
            string actual = lc.GetNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "one hundred")]
        [TestCase(400, "four hundred")]
        [TestCase(700, "seven hundred")]
        public void Verify_YouCanGet_MultiplesOf100_InWords(int number, string expected)
        {
            LettersCount lc = new LettersCount();
            string actual = lc.GetNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101, "one hundred and one")]
        [TestCase(225, "two hundred and twenty-five")]
        [TestCase(690, "six hundred and ninety")]
        [TestCase(999, "nine hundred and ninety-nine")]
        public void Verify_YouCanGet_Hundreds_InWords(int number, string expected)
        {
            LettersCount lc = new LettersCount();
            string actual = lc.GetNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101, 16)]
        [TestCase(225, 23)]
        [TestCase(690, 19)]
        [TestCase(1, 3)]
        [TestCase(17, 9)]
        [TestCase(75, 11)]
        public void Verify_YouCanGet_NumbersLength(int number, int expected)
        {
            LettersCount lc = new LettersCount();
            int actual = lc.GetLettersCountInNumber(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,2, 6)]
        [TestCase(10,20, 76)]
        [TestCase(1,1000,20915)]
       
        public void Verify_YouCanCalculate_TotalLettersForARange(int start, int end, int expected)
        {
            LettersCount lc = new LettersCount();
            int actual = lc.CalculateLettersForaRange(start,end);
            Assert.AreEqual(expected, actual);
        }
    }
}
