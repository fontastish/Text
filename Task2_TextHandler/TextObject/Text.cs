using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Text
    {
        public ICollection<Sentence> TextCollection { get; set; }

        public Text(List<Sentence> textCollection)
        {
            TextCollection = textCollection;
        }

        public Text()
        {
            TextCollection = new List<Sentence>();
        }

        public void AddSentence(Sentence sentence)
        {
            TextCollection.Add(sentence);
        }
    }
}
