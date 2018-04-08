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
        
    }
}
