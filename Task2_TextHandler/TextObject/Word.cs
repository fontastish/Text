using System.Linq;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class Word : ISentenceElement
    {
        public string WordString { get; private set; }


        public Word(string wordString)
        {
            WordString = wordString;
        }

        public string GetSentenceElementString()
        {
            return WordString;
        }

        public bool FirstLetterIsConsonant()
        {
            return "aAeEiIoOuUyY".Any(x => x != WordString[0]);
        }

        public void Replace(string newValue)
        {
            WordString = newValue;
        }
    }
}