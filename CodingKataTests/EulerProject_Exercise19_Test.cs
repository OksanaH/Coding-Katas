using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingKataClassLibrary;
using NUnit.Framework;

namespace CodingKataTests
{
  
    [TestFixture]  
    public class EulerProject_Exercise19_Test
    {
        //https://projecteuler.net/problem=19
        [Test]
        public void Verify_NumberOfSundays_LastCentury()
        {
            SundaysCalculator calculator = new SundaysCalculator();
            int actual = calculator.CalculateSundaysLastCentury();
            int expected = 172;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
