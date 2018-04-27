using System;

namespace KatasTest
{
    using Katas;

    using NUnit.Framework;
    using NUnit.Framework.Internal;

    public class ExesAndOhs
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, Katas.ExesAndOhs.XO("xo"));
            Assert.AreEqual(true, Katas.ExesAndOhs.XO("xxOo"));
            Assert.AreEqual(false, Katas.ExesAndOhs.XO("xxxm"));
            Assert.AreEqual(false, Katas.ExesAndOhs.XO("Oo"));
            Assert.AreEqual(false, Katas.ExesAndOhs.XO("ooom"));
        }
    }
}