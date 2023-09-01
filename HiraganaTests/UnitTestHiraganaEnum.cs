using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

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
                     new object[] {"あ", HiraganaGojuuonEnum.A.Syllable()},
                     new object[] {"い", HiraganaGojuuonEnum.I.Syllable()},
                     new object[] {"う", HiraganaGojuuonEnum.U.Syllable()},
                     new object[] {"え", HiraganaGojuuonEnum.E.Syllable()},
                     new object[] {"お", HiraganaGojuuonEnum.O.Syllable()},
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
                    new object[] {"か", HiraganaGojuuonEnum.KA.Syllable()},
                    new object[] {"き", HiraganaGojuuonEnum.KI.Syllable()},
                    new object[] {"く", HiraganaGojuuonEnum.KU.Syllable()},
                    new object[] {"け", HiraganaGojuuonEnum.KE.Syllable()},
                    new object[] {"こ", HiraganaGojuuonEnum.KO.Syllable()},
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
                    new object[] {"さ", HiraganaGojuuonEnum.SA.Syllable()},
                    new object[] {"し", HiraganaGojuuonEnum.SHI.Syllable()},
                    new object[] {"す", HiraganaGojuuonEnum.SU.Syllable()},
                    new object[] {"せ", HiraganaGojuuonEnum.SE.Syllable()},
                    new object[] {"そ", HiraganaGojuuonEnum.SO.Syllable()},
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
                    new object[] {"た", HiraganaGojuuonEnum.TA.Syllable()},
                    new object[] {"ち", HiraganaGojuuonEnum.CHI.Syllable()},
                    new object[] {"つ", HiraganaGojuuonEnum.TSU.Syllable()},
                    new object[] {"て", HiraganaGojuuonEnum.TE.Syllable()},
                    new object[] {"と", HiraganaGojuuonEnum.TO.Syllable()},
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
                    new object[] {"な", HiraganaGojuuonEnum.NA.Syllable()},
                    new object[] {"に", HiraganaGojuuonEnum.NI.Syllable()},
                    new object[] {"ぬ", HiraganaGojuuonEnum.NU.Syllable()},
                    new object[] {"ね", HiraganaGojuuonEnum.NE.Syllable()},
                    new object[] {"の", HiraganaGojuuonEnum.NO.Syllable()},
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
                    new object[] {"は", HiraganaGojuuonEnum.HA.Syllable()},
                    new object[] {"ひ", HiraganaGojuuonEnum.HI.Syllable()},
                    new object[] {"ふ", HiraganaGojuuonEnum.FU.Syllable()},
                    new object[] {"へ", HiraganaGojuuonEnum.HE.Syllable()},
                    new object[] {"ほ", HiraganaGojuuonEnum.HO.Syllable()},
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
                    new object[] {"ま", HiraganaGojuuonEnum.MA.Syllable()},
                    new object[] {"み", HiraganaGojuuonEnum.MI.Syllable()},
                    new object[] {"む", HiraganaGojuuonEnum.MU.Syllable()},
                    new object[] {"め", HiraganaGojuuonEnum.ME.Syllable()},
                    new object[] {"も", HiraganaGojuuonEnum.MO.Syllable()},
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
                    new object[] {"や", HiraganaGojuuonEnum.YA.Syllable()},
                    new object[] {"ゆ", HiraganaGojuuonEnum.YU.Syllable()},
                    new object[] {"よ", HiraganaGojuuonEnum.YO.Syllable()},
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
                    new object[] {"ら", HiraganaGojuuonEnum.RA.Syllable()},
                    new object[] {"り", HiraganaGojuuonEnum.RI.Syllable()},
                    new object[] {"る", HiraganaGojuuonEnum.RU.Syllable()},
                    new object[] {"れ", HiraganaGojuuonEnum.RE.Syllable()},
                    new object[] {"ろ", HiraganaGojuuonEnum.RO.Syllable()},
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
                    new object[] {"わ", HiraganaGojuuonEnum.WA.Syllable()},
                    new object[] {"ゐ", HiraganaGojuuonEnum.WI.Syllable()},
                    new object[] {"ゑ", HiraganaGojuuonEnum.WE.Syllable()},
                    new object[] {"を", HiraganaGojuuonEnum.WO.Syllable()},
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
                    new object[] {"ん", HiraganaGojuuonEnum.N.Syllable()},
                };
            }
        }
        #endregion
    }
}