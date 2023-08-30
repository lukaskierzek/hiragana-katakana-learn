﻿using HiraganaKatakanaLearn.HelpingFunctions.Classes;

namespace HiraganaKatakanaLearnTests
{
    public class UnitTestApp
    {
        [Fact]
        public void TestReturnStringAppReadOption()
        {
            var expected = "1";
            Console.SetIn(new StringReader(expected));
            var actual = App.ReadOption();
            Assert.Equal(expected, actual);
        }
    }
}