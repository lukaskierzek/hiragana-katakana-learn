using HiraganaKatakanaLearn.HelpingFunctions;
using HiraganaKatakanaLearn.Hiragana.Enums;
namespace HiraganaTests
{
    public class UnitTestHiraganaEnum
    {
        [Theory, MemberData(nameof(HiraganaSyllabeVowels))]
        public void GetHiraganaSyllabeVowels(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsK))]
        public void GetHiraganaSyllabeConstansK(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

        [Theory, MemberData(nameof(HiraganaSyllabeConsonantsS))]
        public void GetHiraganaSyllabeConstansS(string syllabe, string syllabeFromEnum) => Assert.Equal(syllabe, syllabeFromEnum);

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
    }
}