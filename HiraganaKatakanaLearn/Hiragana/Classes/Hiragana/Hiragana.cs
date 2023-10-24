using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana : IHiragana
    {
        public static void LearnHiragana()
        {
            var newQuestion = false;
            var answeredList = new List<string>();
            var hiraganaGojuuonList = HiraganaGojuuonList();
            string syllable;
            HiraganaGojuuonEnum enumHiraganaGojuuon;

            QuestionHiraganaGojuuon(answeredList, hiraganaGojuuonList, out syllable, out enumHiraganaGojuuon);

            MainLoopLearn(ref newQuestion, answeredList, ref hiraganaGojuuonList, ref syllable, ref enumHiraganaGojuuon);
        }
    }
}