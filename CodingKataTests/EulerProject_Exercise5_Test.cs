using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingKataClassLibrary;
using NUnit.Framework;


namespace CodingKataTests
{
  
    [TestFixture]  
    public class EulerProject_Exercise5_Test
    {
        //https://projecteuler.net/problem=5
        [TestCase(new int[] { 1,10}, 100)]
        public void Verify_NumberIsNot_Multipliable_ByAllNumbersInRange(int[] range, int expected)
        {
            SmallestMultipleFinder multFinder = new SmallestMultipleFinder(range);
            Assert.IsFalse(multFinder.CanBeMultipliedByAllNumbersInRange(expected));
        }

        [TestCase(new int[] { 1, 10 }, 2520)]
        public void Verify_NumberIs_Multipliable_ByAllNumbersInRange(int[] range, int expected)
        {
            SmallestMultipleFinder multFinder = new SmallestMultipleFinder(range);
            Assert.IsTrue(multFinder.CanBeMultipliedByAllNumbersInRange(expected));
        }

        [TestCase(new int[] { 1, 10 }, 2520)]
        [TestCase(new int[] { 1, 20 }, 232792560)]
        public void Verify_CanFind_SmallestMultiple(int[] range, int expected)
        { 
            SmallestMultipleFinder multFinder = new SmallestMultipleFinder(range);
            Assert.AreEqual(expected, multFinder.FindSmallestMultiple());
        }
    }
}
