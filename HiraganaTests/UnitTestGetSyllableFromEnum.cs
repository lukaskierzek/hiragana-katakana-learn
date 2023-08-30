using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearnTests
{
    public class UnitTestGetSyllableFromEnum
    {
        [Fact]
        public void TestGetValueFromSyllableAttribute()
        {
            var expected = "こ";
            var actual = GetSyllableFromEnum.Syllable(HiraganaEnum.KO);
            Assert.Equal(expected!, actual!);
        }
    }
}