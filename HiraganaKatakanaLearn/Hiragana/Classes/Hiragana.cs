using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;
using System;

namespace HiraganaKatakanaLearn.Hiragana.Classes
{
    public class Hiragana : IHiragana
    {
        public static List<string> HiraganaList()
        {
            var hiraganaList = Enum.GetValues(typeof(HiraganaEnum)).Cast<HiraganaEnum>().Select(x => x.ToString()).ToList();
            return hiraganaList;
        }
        public static void LearnHiragana()
        {
            var newQuestion = false;
            var answeredList = new List<string>();
            var hiraganaList = HiraganaList();
            string syllable;
            HiraganaEnum enumHiragana;

            QuestionHiragana(answeredList, hiraganaList, out syllable, out enumHiragana);

            while (true)
            {
                if (newQuestion)
                {
                    answeredList.Clear();
                    hiraganaList.Clear();
                    hiraganaList = HiraganaList();
                    QuestionHiragana(answeredList, hiraganaList, out syllable, out enumHiragana);
                }

                Console.WriteLine($"==  {enumHiragana.Syllable()}  ==");
                foreach (var item in answeredList)
                    Console.WriteLine($"> {item}");

                Console.Write("Enter answer: ");
                var option = App.ReadOption().ToUpper();
                if (option != syllable)
                {
                    App.ShowNoticeMessage("Nope!\nEnter to any key to again!");
                    Console.Clear();
                }
                else if (option == syllable)
                {
                    Console.WriteLine("せいかい！");
                    Console.WriteLine("Again? [Y/N]");
                    var continueOption = App.ReadOption().ToUpper();
                    if (continueOption == "Y")
                    {
                        Console.Clear();
                        newQuestion = true;
                    }
                    else if (continueOption == "N")
                        break;
                }
            }
            App.ShowNoticeMessage("Enter to any key to return to menu");
            Console.Clear();
        }

        public static HiraganaEnum GetSyllableFromHiraganaEnum(string syllable) => (HiraganaEnum)Enum.Parse(typeof(HiraganaEnum), syllable, true);

        private static void QuestionHiragana(List<string> answeredList, List<string> hiraganaList, out string syllable, out HiraganaEnum enumHiragana)
        {
            for (int i = 1; i <= 4; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref hiraganaList));

            syllable = App.GetRandomSyllableFromList(answeredList);
            enumHiragana = GetSyllableFromHiraganaEnum(syllable);
        }
    }
}