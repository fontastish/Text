using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class Word : ISentenceElement
    {
        public string WordString { get; set; }


        public Word(string wordString)
        {
            WordString = wordString;
        }

        public string GetSentenceElementString()
        {
            return WordString;
        }

        public bool FirstLetterIsConsonant()
        {
            return "aAeEiIoOuUyY".Any(x => x != WordString[0]);
        }

    }
}
