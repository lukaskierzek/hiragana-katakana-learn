using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;
using System;

namespace HiraganaKatakanaLearn.Hiragana.Classes
{
    public class Hiragana : IHiragana
    {
        public static List<string> HiraganaGojuuonList()
        {
            var hiraganaGojuuonList = Enum.GetValues(typeof(HiraganaGojuuonEnum)).Cast<HiraganaGojuuonEnum>().Select(x => x.ToString()).ToList();
            return hiraganaGojuuonList;
        }
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

                Console.WriteLine($"==  {enumHiraganaGojuuon.Syllable()}  ==");
                foreach (var item in answeredList)
                    Console.WriteLine($"> {item}");
                Console.Write("Enter answer: ");

                var option = App.ReadOption().ToUpper();
                if (option != syllable)
                {
                    App.ShowNoticeMessage("Nope!\nEnter to any key to again!");
                    Console.Clear();
                    newQuestion = false;
                }
                else if (option == syllable)
                {
                    App.ShowNoticeGoodAnswer();
                    while (true)
                    {
                        var continueOption = App.ReadOption().ToUpper();
                        if (continueOption == "Y")
                        {
                            Console.Clear();
                            newQuestion = true;
                            break;
                        }
                        else if (continueOption == "N")
                        {
                            returnToMenu = true;
                            break;
                        }
                    }
                }
                if (returnToMenu)
                    break;
            }
            App.ShowNoticeMessage("Enter to any key to return to menu");
            Console.Clear();
        }

        public static HiraganaGojuuonEnum GetSyllableFromHiraganaGojuuonEnum(string syllable) => (HiraganaGojuuonEnum)Enum.Parse(typeof(HiraganaGojuuonEnum), syllable, true);

        private static void QuestionHiraganaGojuuon(List<string> answeredList, List<string> hiraganaGojuuonList, out string syllable, out HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            for (int i = 1; i <= 4; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref hiraganaGojuuonList));

            syllable = App.GetRandomSyllableFromList(answeredList);
            enumHiraganaGojuuon = GetSyllableFromHiraganaGojuuonEnum(syllable);
        }
    }
}