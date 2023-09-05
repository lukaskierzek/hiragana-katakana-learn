using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
{
    public class AppConsts
    {
        #region Consts string
        public const string AgainNo = "N";
        public const string AgainYes = "Y";
        public const string AgainQuestion = $"Again? [{AgainYes}/{AgainNo}]";
        public const string EnterAnswer = "Enter answer: ";
        public const string EnterKeyAgain = "Nope!\nEnter to any key to again!";
        public const string EnterKeyReturnMenu = "Enter to any key to return to menu";
        public const string WrongOptions = "Wrong option!\nEnter any key to continue";
        public const string JapaneseCorrectAnswer = "せいかい！";
        public const string JapaneseSeeYouLater = "行ってきます！";
        public const string AppTitle = "Hiragana Katakana Learn";
        #endregion

        #region Consts int
        public const int MaxNumberAnswers = 4;
        #endregion
    }
}