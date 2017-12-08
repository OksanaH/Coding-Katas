using System;
using NUnit.Framework;


using CodingKataClassLibrary;
using System.Collections.Generic;

namespace CodingKataTests
{
    [TestFixture]
    public class HarryBooksTests
    {
        private int[] TestSet1;
        private int[] TestSet2;
        private int[] TestSet3;

        //provides a common set of functions that are performed just before each test method is called
        [SetUp]public void Init()
        {
            TestSet1 = new int[] { 1, 1, 2, 2, 3, 3, 4, 5 };
            TestSet2 = new int[] { 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 5 };
            TestSet3 = new int[] { 1, 2, 2, 3, 4 };
        }
        [Test]
        public void TestFillArrays()
        {
            List<int[]> expected = new List<int[]>();
            expected.Add(new int[] { 1, 1, 1, 1, 0 });
            expected.Add(new int[] { 1, 1, 1, 0, 1 });
            HarryBooks books = new HarryBooks();
            Assert.AreEqual(expected, books.CreateBookSets(TestSet1, 3, 2));
        }

        [Test]
        public void TestCalCost()
        {
            List<int[]> sets = new List<int[]>();
            sets.Add(new int[] { 1, 1, 1, 1, 0 });
            sets.Add(new int[] { 1, 1, 1, 0, 1 });

            List<int[]> sets1 = new List<int[]>();
            sets1.Add(new int[] { 1, 1, 1, 1, 1 });
            sets1.Add(new int[] { 1, 1, 1, 0, 1 });
            sets1.Add(new int[] { 1, 0, 0, 0,1 });

            List<int[]> sets2 = new List<int[]>();
            sets2.Add(new int[] { 1, 1, 1, 1, 1 });
            sets2.Add(new int[] { 1, 1, 1, 0, 1 });
            sets2.Add(new int[] { 1, 0, 0, 0, 1 });
            HarryBooks books = new HarryBooks();

            Assert.AreEqual("51.20", books.CalcCost(sets));
            Assert.AreEqual("70.80", books.CalcCost(sets1));
        }
        [Test]
        public void TestCalcCostOfBasket()
        {
            string expected = "51.20";
            string expected2 = "72.80";
            string expected3 = "36.80";
            HarryBooks books = new HarryBooks();
            Assert.AreEqual(expected, books.CalculateCostOfBasket(TestSet1));
            Assert.AreEqual(expected2, books.CalculateCostOfBasket(TestSet2));
            Assert.AreEqual(expected3, books.CalculateCostOfBasket(TestSet3));

        }

    }
}

