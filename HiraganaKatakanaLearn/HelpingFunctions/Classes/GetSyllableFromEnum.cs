using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.HelpingFunctions.Classes
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
            var attribute = (SyllableAttribute)memberInfo[0].GetCustomAttributes(typeof(SyllableAttribute), false)[0];
            var result = attribute.Syllable;
            return result;
        }
    }
}