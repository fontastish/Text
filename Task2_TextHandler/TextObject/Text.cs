using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Task2_TextHandler.TextObject
{
    public class Text : ICloneable
    {
        public List<Sentence> TextCollection { get; set; }


        public Text()
        {
            TextCollection = new List<Sentence>();
        }

        public Text(List<Sentence> textCollection)
        {
            TextCollection = textCollection;
        }

        public void RemoveWordsWithFirstConsonant(int wordLenght)
        {
            foreach (var sentence in TextCollection)
            {
                foreach (var x in sentence.SentenceList.FindAll(x=>x is Word).Cast<Word>())
                {
                    if (x.FirstLetterIsConsonant() == true && x.WordString.Length == wordLenght)
                        sentence.SentenceList.Remove(x);
                } 
            }
        }

        public void ReplaceWords(int indexSentense, int wordLenght, string newValue)
        {
            try
            {
                foreach (var word in TextCollection[indexSentense].SentenceList.FindAll(x => x is Word).Cast<Word>())
                {
                    if (word.WordString.Length == wordLenght)
                        word.WordString = newValue;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Index was out of range");
            }
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
            StringBuilder strout = new StringBuilder();
            foreach (var x in TextCollection)
            {
                strout.Append(x + " ");
            }
                
            return strout.ToString();
        }

        public object Clone()
        {
            var clone = new List<Sentence>(TextCollection.Count);
            foreach (var sentence in TextCollection)
            {
                clone.Add((Sentence)sentence.Clone());
            }

            return new Text(clone);
        }
    }
}
