using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.HelpingFunctions.Interfaces
{
    public interface IHiragana
    {
        static abstract void LearnHiragana();
        static abstract List<string> HiraganaList();
        static abstract HiraganaGojuuonEnum GetSyllableFromHiraganaEnum(string syllable);
    }
}