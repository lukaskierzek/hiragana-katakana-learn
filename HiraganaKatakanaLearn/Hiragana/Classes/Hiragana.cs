using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;
using System;

namespace HiraganaKatakanaLearn.Hiragana.Classes
{
    public class Hiragana : IHiragana
    {
        public static List<string> HiraganaGojuuonList() => App.GetSyllabaryGojuuonList(typeof(HiraganaGojuuonEnum));
        public static void LearnHiragana()
        {
            var newQuestion = false;
            var answeredList = new List<string>();
            var hiraganaGojuuonList = HiraganaGojuuonList();
            string syllable;
            HiraganaGojuuonEnum enumHiraganaGojuuon;

            QuestionHiraganaGojuuon(answeredList, hiraganaGojuuonList, out syllable, out enumHiraganaGojuuon);

            MainLoopLearn(ref newQuestion, answeredList, ref hiraganaGojuuonList, ref syllable, ref enumHiraganaGojuuon);
        }

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

        private static void PrintHeaderWithAnswers(List<string> answeredList, HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            Console.WriteLine($"==  {enumHiraganaGojuuon.Syllable()}  ==");
            foreach (var item in answeredList)
                Console.WriteLine($"> {item}");
            Console.Write(AppConsts.EnterAnswer);
        }

        public static HiraganaGojuuonEnum GetSyllableFromHiraganaGojuuonEnum(string syllable) => (HiraganaGojuuonEnum)Enum.Parse(typeof(HiraganaGojuuonEnum), syllable, true);

        private static void QuestionHiraganaGojuuon(List<string> answeredList, List<string> hiraganaGojuuonList, out string syllable, out HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            for (int i = 1; i <= AppConsts.MaxNumberAnswers; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref hiraganaGojuuonList));

            syllable = App.GetRandomSyllableFromList(answeredList);
            enumHiraganaGojuuon = GetSyllableFromHiraganaGojuuonEnum(syllable);
        }
    }
}