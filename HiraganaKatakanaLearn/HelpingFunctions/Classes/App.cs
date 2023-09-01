using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;

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
            Console.WriteLine("せいかい！");
            Console.WriteLine("Again? [Y/N]");
        }
    }
}