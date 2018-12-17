using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_TextHandler.Interfaces;
using Task2_TextHandler.TextObject;

namespace Task2_TextHandler.Worker
{
    public class TextAnalysis
    {
        public Dictionary<Word, int> Statistic { get; set; }

        public TextAnalysis(Text parseText)
        {
            Statistic = new Dictionary<Word, int>();
            Analysis(parseText);
        }

        public void Analysis(Text parseText)
        {
            Text tempParseText;
            var linqElements = (from u in parseText.TextCollection
                from e in u.SentenceList
                where e is Word
                orderby e
                select e);

            var tempList = linqElements.Cast<Word>().ToList();
            for (var i = 0; i < tempList.Count; i++)
            {
                for (var j = i; j < tempList.Count; j++)
                {
                    if (tempList[i].WordString != tempList[j].WordString)
                    {
                        Statistic.Add(tempList[i],j-i);
                        i = j - 1;
                        break;
                    }
                    if (j == tempList.Count - 1)
                    {
                        Statistic.Add(tempList[i], j - i + 1);
                        i = j;
                    }
                }
            }

        }

        public string PrintTable()
        {
            StringBuilder stringOut = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            foreach (var x in Statistic)
            {
                temp.Clear();
                for (int i = 0; i < x.Value; i++)
                {
                    temp.Append(x.Key.NumberString);
                }
                stringOut.Append(x.Key + "........" + x.Value + ":" + temp + '\n');              
            }

            return stringOut.ToString();
        }

    }
}
