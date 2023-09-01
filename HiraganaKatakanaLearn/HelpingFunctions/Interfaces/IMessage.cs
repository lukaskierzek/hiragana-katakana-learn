namespace HiraganaKatakanaLearn.HelpingFunctions.Interfaces
{
    internal interface IMessage
    {
        static abstract void ShowNoticeMessage(string message);
        static abstract void ShowNoticeGoodAnswer();
    }
}