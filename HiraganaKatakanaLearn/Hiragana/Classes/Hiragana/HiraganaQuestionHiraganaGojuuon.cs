using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana
    {
        private static void QuestionHiraganaGojuuon(List<string> answeredList, List<string> hiraganaGojuuonList, out string syllable, out HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            for (int i = 1; i <= AppConsts.MaxNumberAnswers; i++)
                answeredList.Add(App.GetSyllableFromSyllableList(ref hiraganaGojuuonList));

            syllable = App.GetRandomSyllableFromList(answeredList);
            enumHiraganaGojuuon = GetSyllableFromHiraganaGojuuonEnum(syllable);
        }
    }
}