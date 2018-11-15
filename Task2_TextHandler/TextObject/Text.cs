using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.TextObject
{
    public class Text
    {
        public List<Sentence> TextList { get; }

        public Text(List<Sentence> textList)
        {
            TextList = textList;
        }


    }
}
