using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class PunctuationSign : ISentenceElement
    {
        public string Sign { get; }
        public bool EndSentence { get; }


        public PunctuationSign(string sign, bool endSentence)
        {
            Sign = sign;
            EndSentence = endSentence;
        }

        public string GetSentenceElementString()
        {
            return Sign;
        }

        public bool IsQuestionMark()
        {
            if (Sign.Contains("?"))
                return true;
            return false;
        }
    }
}