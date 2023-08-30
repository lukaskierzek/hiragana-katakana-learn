using HiraganaKatakanaLearn.HelpingFunctions.Classes;
using HiraganaKatakanaLearn.HelpingFunctions.Interfaces;
using HiraganaKatakanaLearn.Hiragana.Enums;

namespace HiraganaKatakanaLearn.Hiragana.Classes
{
    public class Hiragana : IHiragana
    {
        public static void LearnHiragana()
        {
            Console.Clear();
            Console.WriteLine(HiraganaEnum.KI.Syllable());
            Console.WriteLine($"1: {HiraganaEnum.KI}");
            var option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter answer: ");
            while (true)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("GOOD!");

                        return;
                    default:
                        break;
                }
            }
            
       
        }
    }
}