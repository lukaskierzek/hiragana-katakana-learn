using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Katakana.Enums;

namespace KatakanaTests
{
    public class KatakanaEnumData
    {
        public static IEnumerable<object[]> KatakanaSyllableVowels => new[]
        {
            new object[] {"ア", KatakanaGojuuonEnum.A.Syllable()},
            new object[] {"イ", KatakanaGojuuonEnum.I.Syllable()},
            new object[] {"ウ", KatakanaGojuuonEnum.U.Syllable()},
            new object[] {"エ", KatakanaGojuuonEnum.E.Syllable()},
            new object[] {"オ", KatakanaGojuuonEnum.O.Syllable()},
            new object[] {"ン", KatakanaGojuuonEnum.N.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsK => new[]
        {
            new object[] {"カ", KatakanaGojuuonEnum.KA.Syllable()},
            new object[] {"キ", KatakanaGojuuonEnum.KI.Syllable()},
            new object[] {"ク", KatakanaGojuuonEnum.KU.Syllable()},
            new object[] {"ケ", KatakanaGojuuonEnum.KE.Syllable()},
            new object[] {"コ", KatakanaGojuuonEnum.KO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsS => new[]
        {
            new object[] {"サ", KatakanaGojuuonEnum.SA.Syllable()},
            new object[] {"シ", KatakanaGojuuonEnum.SHI.Syllable()},
            new object[] {"ス", KatakanaGojuuonEnum.SU.Syllable()},
            new object[] {"セ", KatakanaGojuuonEnum.SE.Syllable()},
            new object[] {"ソ", KatakanaGojuuonEnum.SO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsT => new[]
        {
            new object[] {"タ", KatakanaGojuuonEnum.TA.Syllable()},
            new object[] {"チ", KatakanaGojuuonEnum.CHI.Syllable()},
            new object[] {"ツ", KatakanaGojuuonEnum.TSU.Syllable()},
            new object[] {"テ", KatakanaGojuuonEnum.TE.Syllable()},
            new object[] {"ト", KatakanaGojuuonEnum.TO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsN => new[]
        {
            new object[] {"ナ", KatakanaGojuuonEnum.NA.Syllable()},
            new object[] {"ニ", KatakanaGojuuonEnum.NI.Syllable()},
            new object[] {"ヌ", KatakanaGojuuonEnum.NU.Syllable()},
            new object[] {"ネ", KatakanaGojuuonEnum.NE.Syllable()},
            new object[] {"ノ", KatakanaGojuuonEnum.NO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsH => new[]
        {
            new object[] {"ハ", KatakanaGojuuonEnum.HA.Syllable()},
            new object[] {"ヒ", KatakanaGojuuonEnum.HI.Syllable()},
            new object[] {"フ", KatakanaGojuuonEnum.FU.Syllable()},
            new object[] {"ヘ", KatakanaGojuuonEnum.HE.Syllable()},
            new object[] {"ホ", KatakanaGojuuonEnum.HO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsM => new[]
        {
            new object[] {"マ", KatakanaGojuuonEnum.MA.Syllable()},
            new object[] {"ミ", KatakanaGojuuonEnum.MI.Syllable()},
            new object[] {"ム", KatakanaGojuuonEnum.MU.Syllable()},
            new object[] {"メ", KatakanaGojuuonEnum.ME.Syllable()},
            new object[] {"モ", KatakanaGojuuonEnum.MO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsY => new[]
        {
            new object[] {"ヤ", KatakanaGojuuonEnum.YA.Syllable()},
            new object[] {"ユ", KatakanaGojuuonEnum.YU.Syllable()},
            new object[] {"ヨ", KatakanaGojuuonEnum.YO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsR => new[]
        {
            new object[] {"ラ", KatakanaGojuuonEnum.RA.Syllable()},
            new object[] {"リ", KatakanaGojuuonEnum.RI.Syllable()},
            new object[] {"ル", KatakanaGojuuonEnum.RU.Syllable()},
            new object[] {"レ", KatakanaGojuuonEnum.RE.Syllable()},
            new object[] {"ロ", KatakanaGojuuonEnum.RO.Syllable()},
        };

        public static IEnumerable<object[]> KatakanaSyllableConsonantsW => new[]
        {
            new object[] {"ワ", KatakanaGojuuonEnum.WA.Syllable()},
            new object[] {"ヰ", KatakanaGojuuonEnum.WI.Syllable()},
            new object[] {"ヱ", KatakanaGojuuonEnum.WE.Syllable()},
            new object[] {"ヲ", KatakanaGojuuonEnum.WO.Syllable()},
        };
    }
}