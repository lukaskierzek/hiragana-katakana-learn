using HiraganaKatakanaLearn.Hiragana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaKatakanaLearn.HelpingFunctions
{
    public static class GetSyllabeFromEnum
    {
        /// <summary>
        /// Get Hiragana or Katakana syllabe
        /// </summary>
        /// <typeparam name="T">HiraganaEnum or KatakanaEnum</typeparam>
        /// <param name="syllabe">Hiragana or Katakana syllabe</param>
        /// <returns>Hiragana or Katakana string syllabe</returns>
        public static string Syllabe<T>(this T syllabe) where T : Enum
        {
            var memberInfo = typeof(T).GetMember(syllabe.ToString());
            var result = ((SyllabeAttribute)memberInfo[0].GetCustomAttributes(typeof(SyllabeAttribute), false)[0]).Syllabe;
            return result;
        }
    }
}