using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Katakana.Enums;
using HiraganaKatakanaLearn.Katakana.Interfaces;

namespace HiraganaKatakanaLearn.Katakana.Classes
{
    public class Katakana : IKatakana
    {
        public static KatakanaGojuuonEnum GetSyllableFromKatakanaGojuuonEnum(string syllable) => (KatakanaGojuuonEnum)Enum.Parse(typeof(KatakanaGojuuonEnum), syllable, true);

        public static List<string> KatakanaGojuuonList() => App.GetSyllabaryGojuuonList(typeof(KatakanaGojuuonEnum));

        public static void LearnKatakana()
        {
            var newQuestion = false;
            var answeredList = new List<string>();
            var katakanaGojuuonList = KatakanaGojuuonList();
            string syllable;
            KatakanaGojuuonEnum enumKatakanaGojuuon;

            QuestionKatakanaGojuuon(answeredList, katakanaGojuuonList, out syllable, out enumKatakanaGojuuon);

            MainLoopLearn(ref newQuestion, answeredList, ref katakanaGojuuonList, ref syllable, ref enumKatakanaGojuuon);
        }

        private static void MainLoopLearn(ref bool newQuestion, List<string> answeredList, ref List<string> katakanaGojuuonList, ref string syllable, ref KatakanaGojuuonEnum enumKatakanaGojuuon)
        {
            while (true)
            {
                var returnToMenu = false;

                if (newQuestion)
                {
                    answeredList.Clear();
                    katakanaGojuuonList.Clear();
                    katakanaGojuuonList = KatakanaGojuuonList();
                    QuestionKatakanaGojuuon(answeredList, katakanaGojuuonList, out syllable, out enumKatakanaGojuuon);
                }

                PrintHeaderWithAnswers(answeredList, enumKatakanaGojuuon);

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

        private static void PrintHeaderWithAnswers(List<string> answeredList, KatakanaGojuuonEnum enumKatakanaGojuuon)
        {
            Console.WriteLine($"==  {enumKatakanaGojuuon.Syllable()}  ==");
            foreach (var item in answeredList)
                Console.WriteLine($"> {item}");
            Console.Write(AppConsts.EnterAnswer);
        }

        private static void QuestionKatakanaGojuuon(List<string> answeredList, List<string> katakanaGojuuonList, out string syllable, out KatakanaGojuuonEnum enumKatakanaGojuuon)
        {
            for (int i = 1; i <= AppConsts.MaxNumberAnswers; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref katakanaGojuuonList));

            syllable = App.GetRandomSyllableFromList(answeredList);
            enumKatakanaGojuuon = GetSyllableFromKatakanaGojuuonEnum(syllable);
        }
    }
}