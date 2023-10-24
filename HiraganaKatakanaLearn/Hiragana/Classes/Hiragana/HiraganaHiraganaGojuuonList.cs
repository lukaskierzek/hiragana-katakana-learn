using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana
    {
        public static List<string> HiraganaGojuuonList() => App.GetSyllabaryGojuuonList(typeof(HiraganaGojuuonEnum));
    }
}