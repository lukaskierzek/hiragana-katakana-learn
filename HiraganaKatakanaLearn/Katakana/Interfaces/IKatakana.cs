using HiraganaKatakanaLearn.Katakana.Enums;

namespace HiraganaKatakanaLearn.Katakana.Interfaces
{
    public interface IKatakana
    {
        static abstract void LearnKatakana();
        static abstract List<string> KatakanaGojuuonList();
        static abstract KatakanaGojuuonEnum GetSyllableFromKatakanaGojuuonEnum(string syllable);
    }
}