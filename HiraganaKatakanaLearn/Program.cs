using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using System.Text;

namespace HiraganaKatakanaLearn
{
    public class Program
    {
        static void Main(string[] args)
         {
            string notice;
            Action<string> NoticeMessage = App.ShowNoticeMessage;
            var consoleSettings = new ConsoleSettings.Settings(Encoding.Default, AppConsts.AppTitle);
            ConsoleSettings.ConsoleSettingsDefault(consoleSettings.encoding, consoleSettings.title);
            while (true)
            {
                App.ShowMenu();
                switch (App.ReadOption())
                {
                    case "1":
                        Console.Clear();
                        Hiragana.Classes.Hiragana.Hiragana.LearnHiragana();
                        break;
                    case "2":
                        Console.Clear();
                        Katakana.Classes.Katakana.LearnKatakana();
                        break;
                    case "3":
                        Console.WriteLine(AppConsts.JapaneseSeeYouLater);
                        return;
                    default:
                        notice = AppConsts.WrongOptions;
                        NoticeMessage(notice);
                        break;
                }
            }
        }
    }
}