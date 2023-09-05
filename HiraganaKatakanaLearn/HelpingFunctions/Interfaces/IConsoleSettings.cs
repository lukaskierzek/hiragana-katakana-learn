using System.Text;

namespace HiraganaKatakanaLearn.HelpingFunctions.Interfaces
{
    internal interface IConsoleSettings
    {
        static abstract void ConsoleSettingsDefault(Encoding encoding, string title);
    }
}