using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Classes;

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
        [MemberData(nameof(ConstsStringApp))]
        [Trait("AppConstsClass", "Consts string")]
        public void TestAppConstsStringAreEqual(string excepted, string actual) => Assert.Equal(excepted!, actual!);
        public static IEnumerable<Object[]> ConstsStringApp
        {
            get
            {
                return new[]
                {
                    new object[] { "Enter to any key to return to menu", AppConsts.EnterKeyReturnMenu},
                    new object[] { "Nope!\nEnter to any key to again!", AppConsts.EnterKeyAgain},
                    new object[] { "Y", AppConsts.AgainYes},
                    new object[] { "N", AppConsts.AgainNo},
                    new object[] { "Enter answer: ", AppConsts.EnterAnswer},
                    new object[] { "Again? [Y/N]", AppConsts.AgainQuestion},
                    new object[] { "Wrong option!\nEnter any key to continue", AppConsts.WrongOptions},
                    new object[] { "せいかい！", AppConsts.JapaneseCorrectAnswer},
                    new object[] { "行ってきます！", AppConsts.JapaneseSeeYouLater},
                };
            }
        }

        [Theory]
        [MemberData(nameof(ConstsIntApp))]
        [Trait("AppConstsClass", "Consts int")]
        public void TestAppConstsIntAreEqual(int excepted, int actual) => Assert.Equal(excepted!, actual!);
        public static IEnumerable<Object[]> ConstsIntApp
        {
            get
            {
                return new[]
                {
                    new object[] { 4, AppConsts.MaxNumberAnswers},
                };
            }
        }
    }
}