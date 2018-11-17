using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Sentence
    {
        public List<ISentenceElement> SentenceList { get; }
        public int CountWords { get; set; } = 0;

        public Sentence()
        {
            SentenceList = new List<ISentenceElement>();
        }

        public void AddSentenceElement(ISentenceElement element)
        {
            SentenceList.Add(element);
            if (element is Word)
                CountWords++;
        }

        public void GetCountWords()                                                        
        {
            var onlyWords = SentenceList.FindAll(x => x is Word);
            CountWords = onlyWords.Count;
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
                strout +=x.ToString();
            }

            return strout;
        }
    }
}
