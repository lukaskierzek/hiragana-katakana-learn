using HiraganaKatakanaLearn.Hiragana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiraganaKatakanaLearn.HelpingFunctions
{
    public class GetSyllabe
    {
        public static string GetKatakanaSyllabe(Enum hiraganaSyllabe)
        {
            if (hiraganaSyllabe.GetType() != typeof(HiraganaEnum))
                throw new Exception("Wrong enum! Only Hiragana");

            var memberInfo = typeof(HiraganaEnum).GetMember(hiraganaSyllabe.ToString());
            var result = ((SyllabeAttribute)memberInfo[0].GetCustomAttributes(typeof(SyllabeAttribute), false)[0]).Syllabe;
            return result;
        }
    }
}
