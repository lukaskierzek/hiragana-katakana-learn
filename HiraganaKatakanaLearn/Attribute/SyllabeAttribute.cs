using System.Net.Mail;

namespace HiraganaKatakanaLearn.Hiragana.Enums
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class SyllabeAttribute : Attribute
    {
        private string _syllabe;
        public string Syllabe
        {
            get { return _syllabe; }
        }
        public SyllabeAttribute(string syllabe)
        {
            this._syllabe = syllabe;
        }
    }
}