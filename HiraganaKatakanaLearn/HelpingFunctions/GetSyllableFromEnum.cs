using HiraganaKatakanaLearn.Hiragana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaKatakanaLearn.HelpingFunctions
{
    public static class GetSyllableFromEnum
    {
        /// <summary>
        /// Get Hiragana or Katakana syllabe
        /// </summary>
        /// <typeparam name="T">HiraganaEnum or KatakanaEnum</typeparam>
        /// <param name="syllabe">Hiragana or Katakana syllabe</param>
        /// <returns>Hiragana or Katakana string syllabe</returns>
        public static string Syllable<T>(this T syllabe) where T : Enum
        {
            var memberInfo = typeof(T).GetMember(syllabe.ToString());
            var result = ((SyllableAttribute)memberInfo[0].GetCustomAttributes(typeof(SyllableAttribute), false)[0]).Syllable;
            return result;
        }
    }
}