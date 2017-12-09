using System;
using CodingKataClassLibrary;
using NUnit.Framework;

namespace CodingKataTests
{
   
    [TestFixture]
    [Category("PrimeFactors")]
    public class EulerProject_Exercise2_Test
    {
        //https://projecteuler.net/problem=3
        [TestCase(15, new int [] { 3, 5 })]
        public void Verify_PrimeFactorsArray_IsCreated_OnClass_Instantiation(int number, int?[] expectedprimeFactorsArray)
        {           
            PrimeFactorFinder PrimeFactorFinder = new PrimeFactorFinder();
            PrimeFactorFinder.SetTargetNumber(number);
            Assert.AreEqual(expectedprimeFactorsArray, PrimeFactorFinder._PrimeFactorsArray);
        }
        
        [TestCase(1200)]
        public void Verify_CanSet_TargetNumber(int number)
        {
            PrimeFactorFinder PrimeFactorFinder = new PrimeFactorFinder();
            PrimeFactorFinder.SetTargetNumber(number);
            Assert.AreEqual(number, PrimeFactorFinder.TargetNumber);
        }

        [TestCase(13)]
        [TestCase(17)]
        [TestCase(19)] 
        public void Verify_Number_Is_Prime(int number)
        {
            PrimeFactorFinder PrimeFactorFinder = new PrimeFactorFinder();
            bool actual = PrimeFactorFinder.IsPrimeFactor(number);
            Assert.IsTrue(actual);            
        }
        [TestCase(6)]
        [TestCase(21)]
        [TestCase(36)]
        //https://projecteuler.net/problem=3

        public void Verify_Number_Is_Not_Prime(int number)
        {
            PrimeFactorFinder PrimeFactorFinder = new PrimeFactorFinder();
            bool actual = PrimeFactorFinder.IsPrimeFactor(number);
            Assert.IsFalse(actual);
        }
       
        //https://projecteuler.net/problem=3
        [TestCase(2, new int[] { 2, 3}, 6)]
        [TestCase(2, new int[] { 4, 10 }, 40)]
        public void Verify_Multiplicator_CanMultiply_TwoNumbers(int numFactors, int[] factors, int result)
        {
            Multiplicator multiplicator = new Multiplicator(numFactors);
            Assert.AreEqual(result, multiplicator.Multiply(factors));
        }

        //https://projecteuler.net/problem=3
        [TestCase(3, new int[] { 4, 7, 10 }, 280)]
        [TestCase(3, new int[] { 5, 7, 11 }, 385)]
        public void Verify_Multiplicator_CanMultiply_ThreeNumbers(int numFactors, int[] factors, int result)
        {
            Multiplicator multiplicator = new Multiplicator(numFactors);
            Assert.AreEqual(result, multiplicator.Multiply(factors));
        }

    }
}
