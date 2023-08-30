using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;
using System.ComponentModel;

namespace HiraganaTests
{
    public class UnitTestHiraganaEnum
    {
        #region Syllables Vowels
        [Theory, MemberData(nameof(HiraganaSyllableVowels)), Trait("SyllablesVowels", "Vowels")]
        public void GetHiraganaSyllableVowels(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableVowels
        {
            get
            {
                return new[]
                {
                     new object[] {"あ", HiraganaEnum.A.Syllable()},
                     new object[] {"い", HiraganaEnum.I.Syllable()},
                     new object[] {"う", HiraganaEnum.U.Syllable()},
                     new object[] {"え", HiraganaEnum.E.Syllable()},
                     new object[] {"お", HiraganaEnum.O.Syllable()},
                };
            }

        }
        #endregion

        #region Syllables Constans K
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsK)), Trait("SyllablesConstans", "ConstansK")]
        public void GetHiraganaSyllableConstansK(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsK
        {
            get
            {
                return new[]
                {
                    new object[] {"か", HiraganaEnum.KA.Syllable()},
                    new object[] {"き", HiraganaEnum.KI.Syllable()},
                    new object[] {"く", HiraganaEnum.KU.Syllable()},
                    new object[] {"け", HiraganaEnum.KE.Syllable()},
                    new object[] {"こ", HiraganaEnum.KO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans S
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsS)), Trait("SyllablesConstans", "ConstansS")]
        public void GetHiraganaSyllableConstansS(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsS
        {
            get
            {
                return new[]
                {
                    new object[] {"さ", HiraganaEnum.SA.Syllable()},
                    new object[] {"し", HiraganaEnum.SHI.Syllable()},
                    new object[] {"す", HiraganaEnum.SU.Syllable()},
                    new object[] {"せ", HiraganaEnum.SE.Syllable()},
                    new object[] {"そ", HiraganaEnum.SO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans T
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsT)), Trait("SyllablesConstans", "ConstansT")]
        public void GetHiraganaSyllableConstansT(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsT
        {
            get
            {
                return new[]
                {
                    new object[] {"た", HiraganaEnum.TA.Syllable()},
                    new object[] {"ち", HiraganaEnum.CHI.Syllable()},
                    new object[] {"つ", HiraganaEnum.TSU.Syllable()},
                    new object[] {"て", HiraganaEnum.TE.Syllable()},
                    new object[] {"と", HiraganaEnum.TO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans N
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsN)), Trait("SyllablesConstans", "ConstansN")]
        public void GetHiraganaSyllableConstansN(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsN
        {
            get
            {
                return new[]
                {
                    new object[] {"な", HiraganaEnum.NA.Syllable()},
                    new object[] {"に", HiraganaEnum.NI.Syllable()},
                    new object[] {"ぬ", HiraganaEnum.NU.Syllable()},
                    new object[] {"ね", HiraganaEnum.NE.Syllable()},
                    new object[] {"の", HiraganaEnum.NO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans H
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsH)), Trait("SyllablesConstans", "ConstansH")]
        public void GetHiraganaSyllableConstansH(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsH
        {
            get
            {
                return new[]
                {
                    new object[] {"は", HiraganaEnum.HA.Syllable()},
                    new object[] {"ひ", HiraganaEnum.HI.Syllable()},
                    new object[] {"ふ", HiraganaEnum.FU.Syllable()},
                    new object[] {"へ", HiraganaEnum.HE.Syllable()},
                    new object[] {"ほ", HiraganaEnum.HO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans M
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsM)), Trait("SyllablesConstans", "ConstansM")]
        public void GetHiraganaSyllableConstansM(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsM
        {
            get
            {
                return new[]
                {
                    new object[] {"ま", HiraganaEnum.MA.Syllable()},
                    new object[] {"み", HiraganaEnum.MI.Syllable()},
                    new object[] {"む", HiraganaEnum.MU.Syllable()},
                    new object[] {"め", HiraganaEnum.ME.Syllable()},
                    new object[] {"も", HiraganaEnum.MO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans Y
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsY)), Trait("SyllablesConstans", "ConstansY")]
        public void GetHiraganaSyllableConstansY(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsY
        {
            get
            {
                return new[]
                {
                    new object[] {"や", HiraganaEnum.YA.Syllable()},
                    new object[] {"ゆ", HiraganaEnum.YU.Syllable()},
                    new object[] {"よ", HiraganaEnum.YO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans R
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsR)), Trait("SyllablesConstans", "ConstansR")]
        public void GetHiraganaSyllableConstansR(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsR
        {
            get
            {
                return new[]
                {
                    new object[] {"ら", HiraganaEnum.RA.Syllable()},
                    new object[] {"り", HiraganaEnum.RI.Syllable()},
                    new object[] {"る", HiraganaEnum.RU.Syllable()},
                    new object[] {"れ", HiraganaEnum.RE.Syllable()},
                    new object[] {"ろ", HiraganaEnum.RO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Constans W
        [Theory, MemberData(nameof(HiraganaSyllableConsonantsW)), Trait("SyllablesConstans", "ConstansW")]
        public void GetHiraganaSyllableConstansW(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableConsonantsW
        {
            get
            {
                return new[]
                {
                    new object[] {"わ", HiraganaEnum.WA.Syllable()},
                    new object[] {"ゐ", HiraganaEnum.WI.Syllable()},
                    new object[] {"ゑ", HiraganaEnum.WE.Syllable()},
                    new object[] {"を", HiraganaEnum.WO.Syllable()},
                };
            }
        }
        #endregion

        #region Syllables Vowel N
        [Theory, MemberData(nameof(HiraganaSyllableVowelN)), Trait("SyllablesVowels", "Vowels")]
        public void GetHiraganaSyllableVowelN(string syllable, string syllableFromEnum) => Assert.Equal(syllable, syllableFromEnum);

        public static IEnumerable<object[]> HiraganaSyllableVowelN
        {
            get
            {
                return new[]
                {
                    new object[] {"ん", HiraganaEnum.N.Syllable()},
                };
            }
        }
        #endregion
    }
}