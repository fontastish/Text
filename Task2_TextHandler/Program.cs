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
            string line = "================================";
            TextReader read = new TextReader("input.txt");
            TextParser parser = new TextParser(read.Read());
            Text text = parser.Parse();
            Console.WriteLine(text);
            //1
            Console.WriteLine(line);
            foreach (var x in text.SortSentences())
            {
                Console.WriteLine(x);
            }
            //2
            Console.WriteLine(line);
            foreach (var x in text.FindWordsOfPredeterminedLength(7))
            {
                Console.WriteLine(x);
            }
            //3
            Console.WriteLine(line);
            var copyOfText = (Text) text.Clone();
            Console.WriteLine(copyOfText);
            //4
            Console.WriteLine(line);
            text.ReplaceWords(0,5,"!!!!");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
