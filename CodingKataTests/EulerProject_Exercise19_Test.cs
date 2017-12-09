using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingKataClassLibrary;

namespace CodingKataTests
{
  
    [TestClass]
    public class EulerProject_Exercise19_Test
    {
        //https://projecteuler.net/problem=19
        [TestCategory("Number of Sundays in the last century")]
        [TestMethod]
        public void Verify_NumberOfSundays_LastCentury()
        {
            SundaysCalculator calculator = new SundaysCalculator();
            int actual = calculator.CalculateSundaysLastCentury();
            int expected = 172;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
