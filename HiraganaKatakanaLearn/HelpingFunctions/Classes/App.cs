using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;
using HiraganaKatakanaLearn.Katakana.Enums;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
{
    public class App : IMenu, IMessage, IReadOptions, IGetSyllableFromSyllableList
    {
        public static string ReadOption()
        {
            var option = Console.ReadLine();
            return option!;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("=========MENU==========");
            Console.WriteLine("[1]  Hiragana");
            Console.WriteLine("[2]  Katakana");
            Console.WriteLine("[3]  Exit");
            Console.Write("Enter option number: ");
        }

        public static void ShowNoticeMessage(string notice)
        {
            Console.WriteLine(notice);
            Console.ReadLine();
            Console.Clear();
        }

        public static string GetRandomSyllableFromList(List<string> answeredList)
        {
            var random = new Random();
            int index = random.Next(answeredList.Count);
            var syllable = answeredList[index];
            return syllable;
        }

        /// <summary>
        /// Return not the same syllables
        /// </summary>
        /// <param name="syllables">List of Hiragana or Katakana</param>
        /// <returns>Syllable</returns>
        public static string GetSyllableFromSyllableList(ref List<string> syllables)
        {
            var syllable = GetRandomSyllableFromList(syllables);
            syllables.Remove(syllable);
            return syllable;
        }

        public static void ShowNoticeGoodAnswer()
        {
            Console.WriteLine(AppConsts.JapaneseCorrectAnswer);
            Console.WriteLine(AppConsts.AgainQuestion);
        }

        public static List<string> GetSyllabaryGojuuonList(Type syllabary)
        {
            if (typeof(HiraganaGojuuonEnum) == syllabary)
                return Enum.GetValues(typeof(HiraganaGojuuonEnum)).Cast<HiraganaGojuuonEnum>().Select(x => x.ToString()).ToList();
            else if (typeof(KatakanaGojuuonEnum) == syllabary)
                return Enum.GetValues(typeof(KatakanaGojuuonEnum)).Cast<KatakanaGojuuonEnum>().Select(x => x.ToString()).ToList();
            else return new List<string>();
        }
    }
}