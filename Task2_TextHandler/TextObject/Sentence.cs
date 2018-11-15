using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Sentence
    {
        public List<Word> SentenceList { get; }

        public Sentence(List<Word> sentenceList)
        {
            SentenceList = sentenceList;
        }
    }
}
