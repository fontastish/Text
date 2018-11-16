using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    class PunctuationSign : ISentenceElement
    {
        public string Sign { get; set; }
        public bool EndSentence { get; set; }


        public PunctuationSign(string sign,bool endSentence)
        {
            Sign = sign;
            EndSentence = endSentence;
        }

    }
}
