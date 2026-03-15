using NUnit.Framework;
using IP_calc;

namespace IP_calc.Tests
{
    [TestFixture]
    public class IpCalculatorTests
    {
        private IpCalculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new IpCalculator();
        }


        // GetBinaryMaskFromPrefix
        [TestCase(24, "11111111111111111111111100000000")]
        [TestCase(16, "11111111111111110000000000000000")]
        [TestCase(8, "11111111000000000000000000000000")]
        public void GetBinaryMaskFromPrefix_ShouldReturnCorrectMask(int prefix, string expected)
        {
            Assert.AreEqual(expected, _calc.GetBinaryMaskFromPrefix(prefix));
        }

        [TestCase(-1)]
        [TestCase(33)]
        public void GetBinaryMaskFromPrefix_InvalidPrefix_ShouldReturnNull(int prefix)
        {
            Assert.IsNull(_calc.GetBinaryMaskFromPrefix(prefix));
        }


        // ToBinaryOctet
        [TestCase("10", "00001010")]
        [TestCase("255", "11111111")]
        [TestCase("0", "00000000")]
        public void ToBinaryOctet_ShouldConvertCorrectly(string input, string expected)
        {
            Assert.AreEqual(expected, _calc.ToBinaryOctet(input));
        }

        // BitwiseAnd
        [TestCase("11110000", "11001100", "11000000")]
        [TestCase("11111111", "00000000", "00000000")]
        [TestCase("10101010", "01010101", "00000000")]
        public void BitwiseAnd_ShouldReturnCorrectResult(string bin1, string bin2, string expected)
        {
            Assert.AreEqual(expected, _calc.BitwiseAnd(bin1, bin2));
        }

        // InvertBinary
        [TestCase("11110000", "00001111")]
        [TestCase("10101010", "01010101")]
        [TestCase("00000000", "11111111")]
        public void InvertBinary_ShouldReturnInvertedString(string input, string expected)
        {
            Assert.AreEqual(expected, _calc.InvertBinary(input));
        }

        // CountMaskBits
        [TestCase("11111111", 8)]
        [TestCase("11110000", 4)]
        [TestCase("00000000", 0)]
        public void CountMaskBits_ShouldReturnCorrectCount(string input, int expected)
        {
            Assert.AreEqual(expected, _calc.CountMaskBits(input));
        }

        // CountZeroBits
        [TestCase("11110000", 4)]
        [TestCase("10100000", 5)]
        [TestCase("11111111", 0)]
        public void CountZeroBits_ShouldReturnCorrectCount(string input, int expected)
        {
            Assert.AreEqual(expected, _calc.CountZeroBits(input));
        }

        // GetNetworkClass
        [TestCase("01010101", "Клас A")]
        [TestCase("10101010", "Клас B")]
        [TestCase("11010101", "Клас C")]
        public void GetNetworkClass_ShouldIdentifyCorrectClass(string input, string expected)
        {
            Assert.AreEqual(expected, _calc.GetNetworkClass(input));
        }

        [Test]
        public void GetNetworkClass_NullInput_ShouldReturnError()
        {
            Assert.AreEqual("Помилка", _calc.GetNetworkClass(null));
        }

        [TestCase("")]
        public void GetNetworkClass_EmptyInput_ShouldReturnError(string input)
        {
            Assert.AreEqual("Помилка", _calc.GetNetworkClass(input));
        }
    }
}