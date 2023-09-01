using HiraganaKatakanaLearn.Hiragana.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaTests
{
    public class UnitTestHiragana
    {
        [Fact]
        public void TestGetHiraganaList()
        {
            var expected = Enum.GetValues(typeof(HiraganaGojuuonEnum)).Cast<HiraganaGojuuonEnum>().Select(x => x.ToString()).ToList();
            var actual = Hiragana.HiraganaList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetSyllableFromHiraganaEnum()
        {
            var expected = HiraganaGojuuonEnum.KI;
            var syllable = "KI";
            var actual = Hiragana.GetSyllableFromHiraganaEnum(syllable!);
            Assert.Equal(expected, actual);
        }
    }
}
