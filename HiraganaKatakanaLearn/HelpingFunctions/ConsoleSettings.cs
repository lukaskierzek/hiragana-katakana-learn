using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaKatakanaLearn.HelpingFunctions
{
    public static class ConsoleSettings
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
