using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Katakana.Enums;

namespace KatakanaTests
{
    public class UnitTestKatakanaEnum
    {
        #region Syllables Vowels
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableVowels), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "Vowels")]
        public void GetKatakanaGojuuonSyllableVowels(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants K
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsK), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsK")]
        public void GetKatakanaGojuuonSyllableConstantsK(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants S
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsK), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsS")]
        public void GetKatakanaGojuuonSyllableConstantsS(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants T
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsK")]
        public void GetKatakanaGojuuonSyllableConstantsT(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants N
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsN")]
        public void GetKatakanaGojuuonSyllableConstantsN(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants H
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsH")]
        public void GetKatakanaGojuuonSyllableConstantsH(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants M
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsM")]
        public void GetKatakanaGojuuonSyllableConstantsM(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants Y
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsY")]
        public void GetKatakanaGojuuonSyllableConstantsY(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants R
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsR")]
        public void GetKatakanaGojuuonSyllableConstantsR(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion

        #region Consonants W
        [Theory]
        [MemberData(nameof(KatakanaEnumData.KatakanaSyllableConsonantsT), MemberType = typeof(KatakanaEnumData))]
        [Trait("Syllables", "ConsonantsW")]
        public void GetKatakanaGojuuonSyllableConstantsW(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);
        #endregion
    }
}