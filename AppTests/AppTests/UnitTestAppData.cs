using HiraganaKatakanaLearn.HelpingFunctions.Classes;

namespace AppTests
{
    public class UnitTestAppData
    {
        public static IEnumerable<object[]> ConstsStringApp => new[]
        {
            new object[] {"Enter to any key to return to menu", AppConsts.EnterKeyReturnMenu},
            new object[] {"Nope!\nEnter to any key to again!", AppConsts.EnterKeyAgain},
            new object[] {"Y", AppConsts.AgainYes},
            new object[] {"N", AppConsts.AgainNo},
            new object[] {"Enter answer: ", AppConsts.EnterAnswer},
            new object[] {"Again? [Y/N]", AppConsts.AgainQuestion},
            new object[] {"Wrong option!\nEnter any key to continue", AppConsts.WrongOptions},
            new object[] {"せいかい！", AppConsts.JapaneseCorrectAnswer},
            new object[] {"行ってきます！", AppConsts.JapaneseSeeYouLater},
            new object[] {"Hiragana Katakana Learn", AppConsts.AppTitle},
        };

        public static IEnumerable<object[]> ConstsIntApp => new[]
        {
            new object[] {4, AppConsts.MaxNumberAnswers},
        };
    }
}