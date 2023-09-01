using HiraganaKatakanaLearn.Katakana.Classes;
using HiraganaKatakanaLearn.Katakana.Enums;

namespace KatakanaTests
{
    public class UnitTestKatakana
    {
        [Fact]
        public void TestGetKatakanaGojuuonList()
        {
            var expected = Enum.GetValues(typeof(KatakanaGojuuonEnum)).Cast<KatakanaGojuuonEnum>().Select(x => x.ToString()).ToList();
            var actual = Katakana.KatakanaGojuuonList();
            Assert.Equal(expected!, actual!);
        }

        [Fact]
        public void TestGetSyllableFromKatakanaGojuuonEnum()
        {
            var expected = KatakanaGojuuonEnum.KI;
            var syllable = "KI";
            var actual = Katakana.GetSyllableFromKatakanaGojuuonEnum(syllable!);
            Assert.Equal(expected!, actual!);
        }
    }
}