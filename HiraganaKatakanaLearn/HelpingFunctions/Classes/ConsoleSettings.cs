using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using System.Text;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
{
    public class ConsoleSettings : IConsoleSettings
    {
        /// <summary>
        /// For a proper display of Japanesse syllables and more.
        /// </summary>
        /// <param name="encoding">Console endocing</param>
        /// <param name="title">Console title</param>
        public static void ConsoleSettingsDefault(Encoding encoding, string title)
        {
            Console.OutputEncoding = encoding;
            Console.Title = title;
        }

        public record Settings(Encoding encoding, string title);
    }
}