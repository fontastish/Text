

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
            parser.Parse();
            Console.ReadKey();
        }
    }
}
