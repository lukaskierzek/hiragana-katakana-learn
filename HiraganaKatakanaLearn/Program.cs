using HiraganaKatakanaLearn.HelpingFunctions.Classes;

namespace HiraganaKatakanaLearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            string notice;
            Action<string> NoticeMessage = App.ShowNoticeMessage;
            ConsoleSettings.EncodingDefault();
            while (true)
            {
                App.ShowMenu();
                switch (App.ReadOption())
                {
                    case "1":
                        Hiragana.Classes.Hiragana.LearnHiragana();
                        break;
                    case "2":
                        notice = "Not implemented!\nEnter any key to continue";
                        NoticeMessage(notice);
                        break;
                    case "3":
                        Console.WriteLine("行ってきます！");
                        return;
                    default:
                        notice = "Wrong option!\nEnter any key to continue";
                        NoticeMessage(notice);
                        break;
                }
            }
        }
    }
}