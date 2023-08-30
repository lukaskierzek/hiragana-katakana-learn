namespace HiraganaKatakanaLearn.Hiragana.Enums
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class SyllableAttribute : Attribute
    {
        private string _syllable;
        public string Syllable
        {
            get { return _syllable; }
        }
        public SyllableAttribute(string syllabe)
        {
            this._syllable = syllabe;
        }
    }
}