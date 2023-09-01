﻿using HiraganaKatakanaLearn.HelpingFunctions.Classes;

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
                        Console.Clear();
                        Hiragana.Classes.Hiragana.LearnHiragana();
                        break;
                    case "2":
                        Console.Clear();
                        Katakana.Classes.Katakana.LearnKatakana();
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