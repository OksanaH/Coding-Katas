using System;
using CodingKataClassLibrary;
using NUnit.Framework;

namespace CodingKataTests
{
   
    [TestFixture]
    //[Category("PrimeNumbers")]
    public class EulerProject_Exercise2_Test
    {
        //https://projecteuler.net/problem=3
        
        [TestCase(1200)]
        public void Verify_CanSet_TargetNumber(int number)
        {
            PrimeNumberFinder PrimeNumberFinder = new PrimeNumberFinder();
            PrimeNumberFinder.SetTargetNumber(number);
            Assert.AreEqual(number, PrimeNumberFinder.TargetNumber);
        }       

        [TestCase(13)]
        [TestCase(17)]
        [TestCase(19)] 
        public void Verify_Number_Is_Prime(int number)
        {
            PrimeNumberFinder PrimeNumberFinder = new PrimeNumberFinder();
            bool actual = PrimeNumberFinder.IsPrimeNumber(number);
            Assert.IsTrue(actual);            
        }
        [TestCase(6)]
        [TestCase(21)]
        [TestCase(36)]      
        public void Verify_Number_Is_Not_Prime(int number)
        {
            PrimeNumberFinder PrimeNumberFinder = new PrimeNumberFinder();
            bool actual = PrimeNumberFinder.IsPrimeNumber(number);
            Assert.IsFalse(actual);
        }    
        [TestCase(new long[] { 2, 3}, 6)]
        [TestCase(new long[] { 4, 10 }, 40)]
        
        public void Verify_Multiplicator_CanFind_Largest_PrimeNumber_InArrayOf2
            (long[] factors, int result)
        {
            PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();
            Assert.AreEqual(factors[1], primeNumberFinder.GetLargestPrimeNumber
                (factors, result));
        }

        [TestCase(new long[] { 4, 7, 10 }, 280)]
        [TestCase(new long[] { 5, 7, 11 }, 385)]
        public void Verify_Multiplicator_CanFind_Largest_PrimeNumber_InArrayOf3
            (long[] factors, int result)
        {
            PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();
            Assert.AreEqual(factors[2], primeNumberFinder.GetLargestPrimeNumber
                (factors, result));
        }

       
        [TestCase(1155, 11)]
        [TestCase(15015, 13)]
        [TestCase(385, 11)]
        [TestCase(13195, 29)]
        [TestCase(600851475143, 255)]
        public void Verify_YouCanFind_LargestNumber(long targetNumber, int maxPrimeNumber)
        {
            PrimeNumberFinder PrimeNumberFinder = new PrimeNumberFinder();
            PrimeNumberFinder.SetTargetNumber(targetNumber);
            Assert.AreEqual(maxPrimeNumber, PrimeNumberFinder.LargestPrimeNumber);
        }
    }
}
