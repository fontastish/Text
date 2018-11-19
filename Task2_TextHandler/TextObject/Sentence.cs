using System;
using System.Collections.Generic;
using System.Text;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class Sentence : ICloneable
    {
        public List<ISentenceElement> SentenceList { get; }
        public int CountWords { get; private set; }


        public Sentence()
        {
            SentenceList = new List<ISentenceElement>();
        }

        public Sentence(List<ISentenceElement> sentenceList)
        {
            SentenceList = sentenceList;
        }

        public object Clone()
        {
            var clone = new List<ISentenceElement>(SentenceList.Count);
            foreach (var word in SentenceList) clone.Add(word);

            return new Sentence(clone);
        }

        public void AddSentenceElement(ISentenceElement element)
        {
            SentenceList.Add(element);
            if (element is Word)
                CountWords++;
        }

        public bool IsQuestionSentences()
        {
            var s = SentenceList.FindLast(x => x is PunctuationSign);
            if (((PunctuationSign) s).IsQuestionMark())
                return true;
            return false;
        }

        public override string ToString()
        {
            var stringout = new StringBuilder();
            foreach (var x in SentenceList)
            {
                if (x is PunctuationSign)
                    stringout.Remove(stringout.Length - 1, 1);
                stringout.Append(x.GetSentenceElementString() + ' ');
            }

            stringout.Remove(stringout.Length - 1, 1);
            return stringout.ToString();
        }
    }
}