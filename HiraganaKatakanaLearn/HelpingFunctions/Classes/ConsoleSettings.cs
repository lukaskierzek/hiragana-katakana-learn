using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using System.Text;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
{
    public class ConsoleSettings : IConsoleSettings
    {
        /// <summary>
        /// For a proper display of Japanesse syllables
        /// </summary>
        public static void EncodingDefault()
        {
            Console.OutputEncoding = Encoding.Default;
        }
    }
}
