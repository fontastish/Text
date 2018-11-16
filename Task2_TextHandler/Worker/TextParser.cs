using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler
{
    public class TextParser
    {
        public bool IsCompletedSentence { get; set; } = false;
        public int Position { get; set; } = 0;
        public int LastPosition { get; set; }
        public StringBuilder SentenceBuilder { get; set; }

        TextParser(List<string> text)
        {
            foreach (var str in text)
            {
                GetSentence(str);
            }
        }

        public void GetSentence(string line)
        {
            char.IsPunctuation()
            if (IsCompletedSentence)
            {
                IsCompletedSentence = false;
                Position = 0;
            }
            SentenceBuilder = new StringBuilder().Append(line);
            for (int i = 0; i < SentenceBuilder.Length; i++)
            {
                
            }

        }
    }
}


//по чар записываем 

