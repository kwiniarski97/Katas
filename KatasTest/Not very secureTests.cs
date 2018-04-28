using System;
using System.Collections.Generic;
using System.Text;

namespace KatasTest
{
    using Katas;

    using NUnit.Framework;

    public class Not_very_secureTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Mazinkaiser").Returns(true);
                yield return new TestCaseData("hello world_").Returns(false);
                yield return new TestCaseData("PassW0rd").Returns(true);
                yield return new TestCaseData("     ").Returns(false);
                yield return new TestCaseData("!TDZeEhP8umlNLocmSy").Returns(false);
                yield return new TestCaseData("").Returns(false);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Not_very_secure.Alphanumeric(str);
    }
}

