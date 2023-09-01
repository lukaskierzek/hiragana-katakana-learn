using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.HelpingFunctions.Interfaces
{
    public interface IHiragana
    {
        static abstract void LearnHiragana();
        static abstract List<string> HiraganaGojuuonList();
        static abstract HiraganaGojuuonEnum GetSyllableFromHiraganaGojuuonEnum(string syllable);
    }
}