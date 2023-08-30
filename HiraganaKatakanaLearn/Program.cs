using HiraganaKatakanaLearn.HelpingFunctions.Classes;

namespace HiraganaKatakanaLearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            string notice;
            ConsoleSettings.EncodingDefault();
            while (true)
            {
                App.ShowMenu();
                switch (App.ReadOption())
                {
                    case "1":
                        //Hiragana.Classes.Hiragana.LearnHiragana();
                        notice = "Not implemented!";
                        App.ShowNoticeMessage(notice);
                        break;
                    case "2":
                        notice = "Not implemented!";
                        App.ShowNoticeMessage(notice);
                        break;
                    case "3":
                        return;
                    default:
                        notice = "Wrong option!";
                        App.ShowNoticeMessage(notice);
                        break;
                }
            }
        }
    }
}