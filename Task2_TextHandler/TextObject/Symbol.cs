using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Symbol
    {

        public string Char { get; }


        public Symbol(string symbol)
        {
            Char = symbol;
        }

        public Symbol(char Char)
        {
            this.Char = $"{Char}";
        }
        
    }
}
