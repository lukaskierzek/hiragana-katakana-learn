using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana
    {
        public static HiraganaGojuuonEnum GetSyllableFromHiraganaGojuuonEnum(string syllable) => (HiraganaGojuuonEnum)Enum.Parse(typeof(HiraganaGojuuonEnum), syllable, true);
    }
}