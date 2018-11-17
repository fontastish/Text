using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Text 
    {
        public List<Sentence> TextCollection { get; set; }

        public Text(List<Sentence> textCollection)
        {
            TextCollection = textCollection;
        }

            

        public List<string> FindWordsOfPredeterminedLength(int wordLength)
        {
            List<string> words = new List<string>();
            foreach (var sentence in TextCollection)
            {
                if (sentence.IsQuestionSentences())
                {
                    foreach (var x in sentence.SentenceList.FindAll(x => x is Word).Cast<Word>())
                    {
                        if (x.WordString.Length == wordLength)
                            words.Add(x.WordString);
                    }
                }

            }

            return words;
        }

        public Text()
        {
            TextCollection = new List<Sentence>();
        }

        public void AddSentence(Sentence sentence)
        {
            TextCollection.Add(sentence);
        }

        public IOrderedEnumerable<Sentence> SortSentences()
        {
            return TextCollection.OrderBy(x => x.CountWords);
        }

        public override string ToString()
        {
            var strout = string.Empty;
            foreach (var x in TextCollection)
            {
                strout += " " + x.ToString();
            }
                
            return strout;
        }
    }
}
