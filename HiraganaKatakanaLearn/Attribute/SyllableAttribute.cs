namespace HiraganaKatakanaLearn.Hiragana.Enums
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class SyllableAttribute : Attribute
    {
        private string _syllable;
        public string Syllable => _syllable;
        public SyllableAttribute(string syllabe)
        {
            _syllable = syllabe;
        }
    }
}