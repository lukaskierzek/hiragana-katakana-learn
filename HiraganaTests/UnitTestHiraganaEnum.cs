using HiraganaKatakanaLearn.HelpingFunctions;
using HiraganaKatakanaLearn.Hiragana.Enums;
namespace HiraganaTests
{
    public class UnitTestHiraganaEnum
    {
        #region Syllabes Vowels
        [Theory, MemberData(nameof(HiraganaSyllabeVowels))]
        public void GetHiraganaSyllabeVowels(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeVowels
        {
            get
            {
                return new[]
                {
                     new object[] {"あ", HiraganaEnum.A.Syllabe()},
                     new object[] {"い", HiraganaEnum.I.Syllabe()},
                     new object[] {"う", HiraganaEnum.U.Syllabe()},
                     new object[] {"え", HiraganaEnum.E.Syllabe()},
                     new object[] {"お", HiraganaEnum.O.Syllabe()},
                };
            }

        }
        #endregion

        #region Syllabes Constans K
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsK))]
        public void GetHiraganaSyllabeConstansK(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsK
        {
            get
            {
                return new[]
                {
                    new object[] {"か", HiraganaEnum.KA.Syllabe()},
                    new object[] {"き", HiraganaEnum.KI.Syllabe()},
                    new object[] {"く", HiraganaEnum.KU.Syllabe()},
                    new object[] {"け", HiraganaEnum.KE.Syllabe()},
                    new object[] {"こ", HiraganaEnum.KO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans S
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsS))]
        public void GetHiraganaSyllabeConstansS(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsS
        {
            get
            {
                return new[]
                {
                    new object[] {"さ", HiraganaEnum.SA.Syllabe()},
                    new object[] {"し", HiraganaEnum.SHI.Syllabe()},
                    new object[] {"す", HiraganaEnum.SU.Syllabe()},
                    new object[] {"せ", HiraganaEnum.SE.Syllabe()},
                    new object[] {"そ", HiraganaEnum.SO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans T
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsT))]
        public void GetHiraganaSyllabeConstansT(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsT
        {
            get
            {
                return new[]
                {
                    new object[] {"た", HiraganaEnum.TA.Syllabe()},
                    new object[] {"ち", HiraganaEnum.CHI.Syllabe()},
                    new object[] {"つ", HiraganaEnum.TSU.Syllabe()},
                    new object[] {"て", HiraganaEnum.TE.Syllabe()},
                    new object[] {"と", HiraganaEnum.TO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans N
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsN))]
        public void GetHiraganaSyllabeConstansN(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsN
        {
            get
            {
                return new[]
                {
                    new object[] {"な", HiraganaEnum.NA.Syllabe()},
                    new object[] {"に", HiraganaEnum.NI.Syllabe()},
                    new object[] {"ぬ", HiraganaEnum.NU.Syllabe()},
                    new object[] {"ね", HiraganaEnum.NE.Syllabe()},
                    new object[] {"の", HiraganaEnum.NO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans H
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsH))]
        public void GetHiraganaSyllabeConstansH(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsH
        {
            get
            {
                return new[]
                {
                    new object[] {"は", HiraganaEnum.HA.Syllabe()},
                    new object[] {"ひ", HiraganaEnum.HI.Syllabe()},
                    new object[] {"ふ", HiraganaEnum.FU.Syllabe()},
                    new object[] {"へ", HiraganaEnum.HE.Syllabe()},
                    new object[] {"ほ", HiraganaEnum.HO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans M
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsM))]
        public void GetHiraganaSyllabeConstansM(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsM
        {
            get
            {
                return new[]
                {
                    new object[] {"ま", HiraganaEnum.MA.Syllabe()},
                    new object[] {"み", HiraganaEnum.MI.Syllabe()},
                    new object[] {"む", HiraganaEnum.MU.Syllabe()},
                    new object[] {"め", HiraganaEnum.ME.Syllabe()},
                    new object[] {"も", HiraganaEnum.MO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans Y
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsY))]
        public void GetHiraganaSyllabeConstansY(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsY
        {
            get
            {
                return new[]
                {
                    new object[] {"や", HiraganaEnum.YA.Syllabe()},
                    new object[] {"ゆ", HiraganaEnum.YU.Syllabe()},
                    new object[] {"よ", HiraganaEnum.YO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans R
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsR))]
        public void GetHiraganaSyllabeConstansR(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsR
        {
            get
            {
                return new[]
                {
                    new object[] {"ら", HiraganaEnum.RA.Syllabe()},
                    new object[] {"り", HiraganaEnum.RI.Syllabe()},
                    new object[] {"る", HiraganaEnum.RU.Syllabe()},
                    new object[] {"れ", HiraganaEnum.RE.Syllabe()},
                    new object[] {"ろ", HiraganaEnum.RO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabes Constans W
        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsW))]
        public void GetHiraganaSyllabeConstansW(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeConsonantsW
        {
            get
            {
                return new[]
                {
                    new object[] {"わ", HiraganaEnum.WA.Syllabe()},
                    new object[] {"ゐ", HiraganaEnum.WI.Syllabe()},
                    new object[] {"ゑ", HiraganaEnum.WE.Syllabe()},
                    new object[] {"を", HiraganaEnum.WO.Syllabe()},
                };
            }
        }
        #endregion

        #region Syllabe Vowel N
        [Theory, MemberData(nameof(HiraganaSyllabeVowelN))]
        public void GetHiraganaSyllabeVowelN(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        public static IEnumerable<object[]> HiraganaSyllabeVowelN
        {
            get
            {
                return new[]
                {
                    new object[] {"ん", HiraganaEnum.N.Syllabe()},
                };
            }
        }
        #endregion
    }
}