using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.TextObject
{
    public class PunctuationSign : ISentenceElement
    {
        public string Sign { get; }
        public bool EndSentence { get; }


        public PunctuationSign(string sign,bool endSentence)
        {
            Sign = sign;
            EndSentence = endSentence;
        }

        public bool IsQuestionMark()
        {
            if (Sign.Contains("?"))
                return true;
            return false;
        }

        public string GetSentenceElementString()
        {
            return Sign;
        }
    }

}
