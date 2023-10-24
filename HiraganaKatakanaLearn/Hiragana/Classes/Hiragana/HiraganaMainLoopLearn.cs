using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana
    {
        private static void MainLoopLearn(ref bool newQuestion, List<string> answeredList, ref List<string> hiraganaGojuuonList, ref string syllable, ref HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            while (true)
            {
                var returnToMenu = false;

                if (newQuestion)
                {
                    answeredList.Clear();
                    hiraganaGojuuonList.Clear();
                    hiraganaGojuuonList = HiraganaGojuuonList();
                    QuestionHiraganaGojuuon(answeredList, hiraganaGojuuonList, out syllable, out enumHiraganaGojuuon);
                }

                PrintHeaderWithAnswers(answeredList, enumHiraganaGojuuon);

                var option = App.ReadOption().ToUpper();
                if (option != syllable)
                {
                    App.ShowNoticeMessage(AppConsts.EnterKeyAgain);
                    Console.Clear();
                    newQuestion = false;
                }
                else if (option == syllable)
                {
                    App.ShowNoticeGoodAnswer();
                    while (true)
                    {
                        var continueOption = App.ReadOption().ToUpper();
                        if (continueOption == AppConsts.AgainYes)
                        {
                            Console.Clear();
                            newQuestion = true;
                            break;
                        }
                        else if (continueOption == AppConsts.AgainNo)
                        {
                            returnToMenu = true;
                            break;
                        }
                    }
                }
                if (returnToMenu)
                    break;
            }
            App.ShowNoticeMessage(AppConsts.EnterKeyReturnMenu);
            Console.Clear();
        }
    }
}