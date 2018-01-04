using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void GivenInteger1_WhenConvertedToRomanNumeral_AssertThatItsI()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(1);
            Assert.AreEqual(romanNumeral, "I");
        }

        [TestMethod]
        public void GivenInteger5_WhenConvertedToRomanNumeral_AssertThatItsV()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(5);
            Assert.AreEqual(romanNumeral, "V");
        }

        [TestMethod]
        public void GivenInteger10_WhenConvertedToRomanNumeral_AssertThatItsX()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(10);
            Assert.AreEqual(romanNumeral, "X");
        }

        [TestMethod]
        public void GivenInteger50_WhenConvertedToRomanNumeral_AssertThatItsL()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(50);
            Assert.AreEqual(romanNumeral, "L");
        }

        [TestMethod]
        public void GivenInteger100_WhenConvertedToRomanNumeral_AssertThatItsC()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(100);
            Assert.AreEqual(romanNumeral, "C");
        }

        [TestMethod]
        public void GivenInteger500_WhenConvertedToRomanNumeral_AssertThatItsD()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(500);
            Assert.AreEqual(romanNumeral, "D");
        }        

        [TestMethod]
        public void GivenInteger1000_WhenConvertedToRomanNumeral_AssertThatItsM()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(1000);
            Assert.AreEqual(romanNumeral, "M");
        }

        [TestMethod]
        public void GivenInteger900_WhenConvertedToRomanNumeral_AssertThatItsCM()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(900);
            Assert.AreEqual(romanNumeral, "CM");
        }

        [TestMethod]
        public void GivenInteger90_WhenConvertedToRomanNumeral_AssertThatItsXC()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(90);
            Assert.AreEqual(romanNumeral, "XC");
        }

        [TestMethod]
        public void GivenInteger9_WhenConvertedToRomanNumeral_AssertThatItsIX()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(9);
            Assert.AreEqual(romanNumeral, "IX");
        }

        [TestMethod]
        public void GivenInteger909_WhenConvertedToRomanNumeral_AssertThatItsCMIX()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(909);
            Assert.AreEqual(romanNumeral, "CMIX");
        }

        [TestMethod]
        public void GivenInteger999_WhenConvertedToRomanNumeral_AssertThatItsCMXCIX()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(999);
            Assert.AreEqual(romanNumeral, "CMXCIX");
        }

        [TestMethod]
        public void GivenInteger49_WhenConvertedToRomanNumeral_AssertThatItsXLIX()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(49);
            Assert.AreEqual(romanNumeral, "XLIX");
        }

        [TestMethod]
        public void GivenInteger400_WhenConvertedToRomanNumeral_AssertThatItsCD()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(400);
            Assert.AreEqual(romanNumeral, "CD");
        }

        [TestMethod]
        public void GivenInteger40_WhenConvertedToRomanNumeral_AssertThatItsXL()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(40);
            Assert.AreEqual(romanNumeral, "XL");
        }

        [TestMethod]
        public void GivenInteger4_WhenConvertedToRomanNumeral_AssertThatItsIV()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(4);
            Assert.AreEqual(romanNumeral, "IV");
        }

        [TestMethod]
        public void GivenInteger723_WhenConvertedToRomanNumeral_AssertThatItsDCCXXIII()
        {
            string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(723);
            Assert.AreEqual(romanNumeral, "DCCXXIII");
        }
    }
}
