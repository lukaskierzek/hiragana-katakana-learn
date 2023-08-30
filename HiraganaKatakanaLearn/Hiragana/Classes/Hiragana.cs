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
            var answeredList = new List<string>();
            var hiraganaList = HiraganaList();

            for (int i = 1; i <= 4; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref hiraganaList));

            var random = new Random();
            int index = random.Next(answeredList.Count);
            var syllable = answeredList[index];

            var enumHiragana = (HiraganaEnum)Enum.Parse(typeof(HiraganaEnum), syllable, true);
            Console.WriteLine($"OK: {enumHiragana.Syllable()}");
            while (true)
            {
                //Console.WriteLine($"==  {syllable}  ==");
                var iA = 1;
                foreach (var item in answeredList)
                {
                    Console.WriteLine($"[{iA}]  {item}");
                    iA++;
                }

                var option = App.ReadOption().ToUpper();
                Console.Write("Enter answer: ");
                if (option != syllable)
                    App.ShowNoticeMessage("Nope!\nEnter to any key to again!");
                else
                    break;
            }
            Console.WriteLine("Gooooood!");
            App.ShowNoticeMessage("Enter to any key to return to menu");
            Console.Clear();


        }
    }
}