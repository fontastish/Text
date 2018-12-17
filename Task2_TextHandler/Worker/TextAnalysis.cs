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
        public Dictionary<string, List<Word>> Statistic { get; set; }

        public TextAnalysis(Text parseText)
        {
            Statistic = new Dictionary<string, List<Word>>();
            Analysis(parseText);
        }

        public void Analysis(Text parseText)
        {
            Text tempParseText;
            var linqElements = from u in parseText.TextCollection
                from e in u.SentenceList
                where e is Word
                orderby e
                select e;

            var tempList = linqElements.Cast<Word>().ToList();
            //var wordList = new List<Word>();

            for (var i = 0; i < tempList.Count; i++)
            {
                var wordList = new List<Word>();
                for (var j = i; j < tempList.Count; j++)
                {
                    if (tempList[i].WordString != tempList[j].WordString)
                    {
                        Statistic.Add(tempList[i].WordString, wordList);
                        i = j - 1;
                        break;
                    }
                    wordList.Add(tempList[j]);         
                    if (j == tempList.Count - 1)
                    {
                        Statistic.Add(tempList[i].WordString, wordList);
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
                for (int i = 0; i < x.Value.Count; i++)
                {
                    temp.Append(" " + x.Value[i].NumberString);
                }
                stringOut.Append(x.Key +".........." + x.Value.Count + ":" + temp + '\n');
            }

            return stringOut.ToString();
        }

    }
}
