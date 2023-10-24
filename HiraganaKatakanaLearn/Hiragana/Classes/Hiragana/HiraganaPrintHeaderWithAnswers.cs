using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes.Hiragana
{
    public partial class Hiragana
    {
        private static void PrintHeaderWithAnswers(List<string> answeredList, HiraganaGojuuonEnum enumHiraganaGojuuon)
        {
            Console.WriteLine($"==  {enumHiraganaGojuuon.Syllable()}  ==");
            foreach (var item in answeredList)
                Console.WriteLine($"> {item}");
            Console.Write(AppConsts.EnterAnswer);
        }
    }
}