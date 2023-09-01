using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaTests
{
    public class UnitTestGetSyllableFromEnum
    {
        [Fact]
        public void TestGetValueFromSyllableAttribute()
        {
            var expected = "こ";
            var actual = GetSyllableFromEnum.Syllable(HiraganaGojuuonEnum.KO);
            Assert.Equal(expected!, actual!);
        }
    }
}