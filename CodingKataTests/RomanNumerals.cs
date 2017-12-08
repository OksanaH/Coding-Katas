using System;
using NUnit.Framework;

using CodingKataClassLibrary;


namespace CodingKataTests
{
    [TestFixture]
    public class TestRomanNumerals
    {
        [Test]
        public void TestArabicToRoman()
        {
            //arrange
            string expected = "";
            //act
            RomanNumerals rn = new RomanNumerals();
           // int actual = rn.ArabicToRoman("");
            //assert

            Assert.AreEqual("", rn.ArabicToRoman(-1));
            Assert.AreEqual("MM", rn.ArabicToRoman(2000));
            Assert.AreEqual("MCM", rn.ArabicToRoman(1900));
            Assert.AreEqual("MCCC", rn.ArabicToRoman(1300));            
            Assert.AreEqual("MCCCLXXX", rn.ArabicToRoman(1380));
            Assert.AreEqual("MDCCCXL", rn.ArabicToRoman(1840));
           
            Assert.AreEqual("MMV", rn.ArabicToRoman(2005));
            Assert.AreEqual("MDCCCXLIV", rn.ArabicToRoman(1844));
            Assert.AreEqual("MMMXXVI", rn.ArabicToRoman(3026));
            Assert.AreEqual("MMCDI", rn.ArabicToRoman(2401));

            Assert.AreEqual("CMXCIX", rn.ArabicToRoman(999));
            Assert.AreEqual("CCCV", rn.ArabicToRoman(305));

            Assert.AreEqual("XVIII", rn.ArabicToRoman(18));
            Assert.AreEqual("XLVII", rn.ArabicToRoman(47));

            Assert.AreEqual("VIII", rn.ArabicToRoman(8));
        }
    }
}
