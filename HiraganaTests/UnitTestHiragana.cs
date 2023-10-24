using HiraganaKatakanaLearn.Hiragana.Classes.Hiragana;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaTests
{
    public class UnitTestHiragana
    {
        [Fact]
        public void TestGetHiraganaGojuuonList()
        {
            var expected = Enum.GetValues(typeof(HiraganaGojuuonEnum)).Cast<HiraganaGojuuonEnum>().Select(x => x.ToString()).ToList();
            var actual = Hiragana.HiraganaGojuuonList();
            Assert.Equal(expected!, actual!);
        }

        [Fact]
        public void TestGetSyllableFromHiraganaGojuuonEnum()
        {
            var expected = HiraganaGojuuonEnum.KI;
            var syllable = "KI";
            var actual = Hiragana.GetSyllableFromHiraganaGojuuonEnum(syllable!);
            Assert.Equal(expected!, actual!);
        }
    }
}