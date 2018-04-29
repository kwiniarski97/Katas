using System;
using System.Collections.Generic;
using System.Text;

namespace KatasTest
{
    using Katas;

    using NUnit.Framework;

    class Convert_PascalCase_string_into_snake_caseTESTS
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("test_controller", Convert_PascalCase_string_into_snake_case.ToUnderscore("TestController"));
            Assert.AreEqual("this_is_beautiful_day", Convert_PascalCase_string_into_snake_case.ToUnderscore("ThisIsBeautifulDay"));
            Assert.AreEqual("am7_days", Convert_PascalCase_string_into_snake_case.ToUnderscore("Am7Days"));
            Assert.AreEqual("my3_code_is4_times_better", Convert_PascalCase_string_into_snake_case.ToUnderscore("My3CodeIs4TimesBetter"));
            Assert.AreEqual("arbitrarily_sending_different_types_to_functions_makes_katas_cool", Convert_PascalCase_string_into_snake_case.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
            Assert.AreEqual("1", Convert_PascalCase_string_into_snake_case.ToUnderscore(1), "Numbers should be turned to strings!");
        }
    }
}
