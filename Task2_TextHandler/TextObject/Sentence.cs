using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Sentence : ICloneable
    {
        public List<ISentenceElement> SentenceList { get; }
        public int CountWords { get; set; } = 0;

        public Sentence()
        {
            SentenceList = new List<ISentenceElement>();
        }

        public Sentence(List<ISentenceElement> sentenceList)
        {
            SentenceList = sentenceList;
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
            var strout = string.Empty;
            foreach (var x in SentenceList)
            {
                strout +=x.GetSentenceElementString();
            }

            return strout;
        }

        public object Clone()
        {
            var clone = new List<ISentenceElement>(SentenceList.Count);
            foreach (var word in SentenceList)
            {
                clone.Add(word);
            }

            return new Sentence(clone);
        }
    }
}
