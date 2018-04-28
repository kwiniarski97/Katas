namespace KatasTest
{
    using Katas;

    using NUnit.Framework;

    public class Roman_Numerals_Decode_Tests
    {
        [TestCase(1, "I")]
        public void Test1(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }

        [TestCase(3, "III")]
        public void Test2(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }

        [TestCase(4, "IV")]
        public void Test3(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }

        [TestCase(92, "XCII")]
        public void Test4(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }

        [TestCase(73, "LXXIII")]
        public void Test5(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }

        [TestCase(1954, "MCMLIV")]
        public void Test6(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }
    }
}