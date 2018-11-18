

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_TextHandler.TextObject;

namespace Task2_TextHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader read = new TextReader("input.txt");
            TextParser parser = new TextParser(read.Read());
            var temp = parser.Parse();
            //1
            foreach (var x in temp.SortSentences())
            {
                Console.WriteLine(x);
            }
            //2
            foreach (var x in temp.FindWordsOfPredeterminedLength(7))
            {
                Console.WriteLine(x);
            }
            //3
            var copyOfText = (Text) temp.Clone();
            copyOfText.RemoveWordsWithFirstConsonant(7);
            Console.WriteLine(temp);
            Console.WriteLine(copyOfText);
            Console.ReadKey();
        }
    }
}
