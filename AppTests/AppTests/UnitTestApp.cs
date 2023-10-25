using AppTests;
using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Classes.Hiragana;

namespace HiraganaTests
{
    public class UnitTestApp
    {
        [Fact]
        public void TestReturnStringAppReadOption()
        {
            var expected = "1";
            Console.SetIn(new StringReader(expected));
            var actual = App.ReadOption();
            Assert.Equal(expected!, actual!);
        }

        [Fact]
        public void TestReturnNotTheSameSyllables()
        {
            var hiraganaList = Hiragana.HiraganaGojuuonList();
            for (int i = 1; i <= 4; i++)
            {
                var syllable = App.GetSyllableFromSyllableList(ref hiraganaList);
                Assert.DoesNotContain(syllable, hiraganaList);
            }
        }

        [Theory]
        [MemberData(nameof(UnitTestAppData.ConstsStringApp), MemberType = typeof(UnitTestAppData))]
        [Trait("AppConstsClass", "Consts string")]
        public void TestAppConstsStringAreEqual(string excepted, string actual) => Assert.Equal(excepted!, actual!);

        [Theory]
        [MemberData(nameof(UnitTestAppData.ConstsIntApp), MemberType = typeof(UnitTestAppData))]
        [Trait("AppConstsClass", "Consts int")]
        public void TestAppConstsIntAreEqual(int excepted, int actual) => Assert.Equal(excepted!, actual!);
    }
}