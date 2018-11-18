using System.Text;
using Task2_TextHandler.TextObject;

namespace Task2_TextHandler.Worker
{
    public class TextParser
    {
        public string Text { get; }


        public TextParser(string text)
        {
            Text = text;
        }

        public Text Parse()
        {
            var text = new Text();
            var sentence = new Sentence();
            var sentenceBuilder = new StringBuilder();
            var isCompletedSentence = true;
            for (var i = 0; i < Text.Length; i++)
            {
                if (isCompletedSentence) 
                {
                    sentence = new Sentence();
                    isCompletedSentence = false;
                }

                while (char.IsLetter(Text[i])) 
                {
                    sentenceBuilder.Append(Text[i]);
                    i++;
                    if (!char.IsLetter(Text[i]))
                    {
                        sentence.AddSentenceElement(new Word(sentenceBuilder.ToString()));
                        sentenceBuilder.Clear();
                    }
                }

                while (char.IsPunctuation(Text[i]))   
                {
                    sentenceBuilder.Append(Text[i]);
                    if (Text[i] == '.' || Text[i] == '!' || Text[i] == '?') 
                        isCompletedSentence = true;
                    i++;
                    if (i == Text.Length) 
                        i--;
                    if (!char.IsPunctuation(Text[i]) || i + 1 == Text.Length)
                    {
                        sentence.AddSentenceElement(
                            new PunctuationSign(sentenceBuilder.ToString(), isCompletedSentence));
                        sentenceBuilder.Clear();
                        break;
                    }
                }

                if (isCompletedSentence) //добавляем готовое преложение, меняем переменную для создания нового
                    text.AddSentence(sentence);
            }

            return text;
        }
    }
}