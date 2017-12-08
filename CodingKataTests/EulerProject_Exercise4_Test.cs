using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingKataClassLibrary;

namespace CodingKataTests
{
    [TestClass]
    public class EulerProject_Exercise4_Test
    {
        //https://projecteuler.net/problem=4
        [TestMethod]
        public void Verify_Number_IsPalindrome()
        {
            PalindromeFinder pf = new PalindromeFinder(2);

            Assert.IsTrue(pf.IsPalindrome(9009));
            
        }
        [TestMethod]
        public void Verify_Number_IsNotPalindrome()
        {
            PalindromeFinder pf = new PalindromeFinder(2);
            Assert.IsTrue(pf.IsPalindrome(11009));
        }

        [TestMethod]
        public void Verify_CanGet_SmallestNumber_With2Digits()
        {
            PalindromeFinder pf = new PalindromeFinder(2);
            Assert.AreEqual(10, pf.SmallestNumber);
        }
        [TestMethod] 
        public void Verify_CanGet_SmallestNumber_With3Digits()
        {
            PalindromeFinder ggpf = new PalindromeFinder(3);
            Assert.AreEqual(100, pf.SmallestNumber);
        }
        [TestMethod]
        public void Verify_CanGet_LargestNumber_With2Digits()
        {
            PalindromeFinder pf = new PalindromeFinder(2);
            Assert.AreEqual(99, pf.LargestNumber);
        }
        [TestMethod]
        public void Verify_CanGet_LargestNumber_With3Digits()
        {
            PalindromeFinder pf = new PalindromeFinder(3);
            Assert.AreEqual(999, pf.LargestNumber);
        }
        [TestMethod]
        public void Verify_CanGet_LargestPalindrome_ProductOfMultiplication_Of2DigitNumbers()
        {
            PalindromeFinder pf = new PalindromeFinder(2);
            Assert.AreEqual(9009, pf.GetLargestPalindrome());
        }
        [TestMethod]
        public void Verify_CanGet_LargestPalindrome_ProductOfMultiplication_Of3DigitNumbers()
        {
            PalindromeFinder pf = new PalindromeFinder(3);
            Assert.AreEqual(906609, pf.GetLargestPalindrome());
        }
    }
}
