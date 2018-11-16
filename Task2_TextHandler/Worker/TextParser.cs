using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_TextHandler.TextObject;

namespace Task2_TextHandler
{
    public class TextParser
    {
        //public bool IsCompletedSentence { get; set; } = false;
        //public int Position { get; set; } = 0;
        //public int LastPosition { get; set; }
        //public StringBuilder SentenceBuilder { get; set; }
        private string _text;

        public TextParser(string text)
        {
            _text = text;
        }

        //public void Parse()
        //{
        //    Text text = new Text();
        //    //bool isSentence = false;
        //    //bool isPunctuationSing = false;
        //    //bool isWord = false;
        //    StringBuilder sentenceBuilder = new StringBuilder();
        //    for (var i = 0; i < _text.Length; i++)
        //    {
        //        while (char.IsLetter(_text[i]))
        //        {
        //            Sentence sentence = new Sentence();
        //            Word word;
        //            sentenceBuilder.Append(_text[i]);
        //            i++;
        //            if (!char.IsLetter(_text[i]))
        //            {
        //                sentence.AddSentenceElement(new Word(sentenceBuilder.ToString()));
        //            }
        //        }

        //        while (_text[i] = )
        //        {

        //        }

        //    }
        //}

        public void Parse()
        {
            Text text = new Text();
            Sentence sentence = new Sentence();
            StringBuilder sentenceBuilder = new StringBuilder();
            bool isCompletedSent = true;
            for (var i = 0; i < _text.Length; i++)
            {
                if (isCompletedSent)
                {
                    sentence = new Sentence();
                    isCompletedSent = false;
                }
                while (char.IsLetter(_text[i]))
                {
                    sentenceBuilder.Append(_text[i]);
                    i++;
                    if (!char.IsLetter(_text[i]))
                    {
                        sentence.AddSentenceElement(new Word(sentenceBuilder.ToString()));
                        sentenceBuilder.Clear();
                    }
                }

                while (char.IsPunctuation(_text[i]) && (i!=_text.Length-1))
                {
                    sentenceBuilder.Append(_text[i]);
                    if(_text[i] == '.' || _text[i] == '!' || _text[i]=='?')
                        isCompletedSent = true;
                    i++;
                    if (!char.IsPunctuation(_text[i]))
                    {
                        sentence.AddSentenceElement(new PunctuationSign(sentenceBuilder.ToString(), isCompletedSent));
                        sentenceBuilder.Clear();
                    }
                }
                if (isCompletedSent)
                    text.AddSentence(sentence);
            }
        }



    }
}



//по чар записываем 

