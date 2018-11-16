using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    class PunctuationSign
    {
        public string Sing { get; set; }
        //private Regex regex = new Regex(@"\b[а-я-[е]]{1,}\b");
        private string pattern = @"[\W^ ]";


        public PunctuationSign(string sing)
        {
            Sing = sing;
        }

        public bool IsSing(string sing)
        {
            if (Regex.IsMatch(sing, pattern))
                return true;
            return false;
        }

    }
}
