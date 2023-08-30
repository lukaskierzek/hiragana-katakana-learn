using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
{
    public class App : IMenu, IMessage, IReadOptions
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
            Console.Write("Enter option: ");
        }

        public static void ShowNoticeMessage(string notice)
        {
            Console.WriteLine($"{notice}\nEnter any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}