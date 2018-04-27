namespace KatasTest
{
    using System;

    using Katas;

    using NUnit.Framework;

    public class Going_to_zero_or_to_infinityTest
    {
        Random randomGenerator = new Random();

        [Test]
        public void Test01()
        {
            Assert.AreEqual(1.275, Going_to_zero_or_to_infinity.going(5));
        }
        [Test]
        public void Test02()
        {
            Assert.AreEqual(1.2125, Going_to_zero_or_to_infinity.going(6));
        }
        [Test]
        public void Test03()
        {
            Assert.AreEqual(1.173214, Going_to_zero_or_to_infinity.going(7));
        }

        [Test]
        public void Test04()
        {
            Assert.AreEqual(1.005682d, Going_to_zero_or_to_infinity.going(66838316423177));
        }
    }
}