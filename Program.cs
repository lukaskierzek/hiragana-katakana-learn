using HiraganaKatakanaLearn.Hiragana.Enums;
using Microsoft.VisualBasic;
using System.Text;

namespace HiraganaKatakanaLearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelpingFunctions.GetSyllabe.GetKatakanaSyllabe(HiraganaEnum.O));

        }

    }
}