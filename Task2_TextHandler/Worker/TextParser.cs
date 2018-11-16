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
        public string Text { get; }

        public TextParser(string text)
        {
            Text = text;
        }

        public Text Parse()
        {
            Text text = new Text();                     // надо везде подумать над именами
            Sentence sentence = new Sentence();
            StringBuilder sentenceBuilder = new StringBuilder();
            bool isCompletedSent = true;
            for (var i = 0; i < Text.Length; i++)
            {
                if (isCompletedSent)                    //создаём новое предложение
                {
                    sentence = new Sentence();
                    isCompletedSent = false;
                }

                while (char.IsLetter(Text[i]))      //читаем слово и добавляем его в предложение
                {
                    sentenceBuilder.Append(Text[i]);
                    i++;
                    if (!char.IsLetter(Text[i]))
                    {
                        sentence.AddSentenceElement(new Word(sentenceBuilder.ToString()));
                        sentenceBuilder.Clear();
                    }
                }

                while (char.IsPunctuation(Text[i]))                 //читаем знак и добавляем в преложение  
                {
                    sentenceBuilder.Append(Text[i]);
                    if (Text[i] == '.' || Text[i] == '!' || Text[i] == '?')         //знак в конце предложения
                        isCompletedSent = true;
                    i++;
                    if (i == Text.Length)                                               //проверка чтобы не было выхода с массива
                        i--;
                    if (!char.IsPunctuation(Text[i]) || (i + 1) == Text.Length)
                    {
                        sentence.AddSentenceElement(new PunctuationSign(sentenceBuilder.ToString(), isCompletedSent));
                        sentenceBuilder.Clear();
                        break;
                    }
                }

                if (isCompletedSent)                            //добавляем готовое преложение, меняем переменную для создания нового
                    text.AddSentence(sentence);
            }

            return text;
        }



    }
}

