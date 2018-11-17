using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Word : ISentenceElement
    {
        public string WordString { get; }

        public Word(string wordString)
        {
            WordString = wordString;
        }

        public override string ToString()
        {
            return " " + WordString;
        }
    }
}
