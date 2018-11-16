using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Sentence
    {
        public ICollection<ISentenceElement> SentenceList { get; set; }

        public Sentence(ICollection<ISentenceElement> sentenceList)
        {
            SentenceList = sentenceList;
        }
        public Sentence()
        {
            SentenceList = new List<ISentenceElement>();
        }

        public void AddSentenceElement(ISentenceElement element)
        {
            SentenceList.Add(element);
        }
    }
}
