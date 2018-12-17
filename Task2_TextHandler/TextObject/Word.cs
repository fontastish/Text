using System;
using System.Linq;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class Word : ISentenceElement, IComparable
    {
        public string WordString { get; private set; }
        public int NumberString { get; }


        public Word(string wordString, int numberString)
        {
            WordString = wordString;
            NumberString = numberString;
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

        public override string ToString()
        {
            return WordString;
        }

        public int CompareTo(object obj)
        {
            return String.Compare(WordString, (obj as Word).WordString, StringComparison.Ordinal);
        }
    }
}