using System;
using System.Collections.Generic;
using System.Text;

namespace KatasTest
{
    using Katas;

    using NUnit.Framework;

    class First_non_repeating_character_TEST
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("a", Kata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Kata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Kata.FirstNonRepeatingLetter("moonmen"));
        }
    }
}
