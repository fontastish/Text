using System;
using Task2_TextHandler.TextObject;
using Task2_TextHandler.Worker;

namespace Task2_TextHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = "================================";
            var read = new TextReader("input.txt");
            var parser = new TextParser(read.Read());
            var text = parser.Parse();
            Console.WriteLine(text);
            //1     ������� ��� ����������� ��������� ������ � ������� ����������� ���������� ���� � ������ �� ���.
            Console.WriteLine(line);
            foreach (var x in text.SortSentences()) Console.WriteLine(x);
            //2     �� ���� �������������� ������������ ������ ����� � ���������� ��� ���������� ����� ��������  �����.
            Console.WriteLine(line);
            foreach (var x in text.FindWordsOfPredeterminedLength(7)) Console.WriteLine(x);
            //3     �� ������ ������� ��� ����� �������� �����, ������������ �� ��������� �����.
            Console.WriteLine(line);
            var copyOfText = (Text) text.Clone();
            copyOfText.RemoveWordsWithFirstConsonant(7);
            Console.WriteLine(copyOfText);
            //4      � ��������� ����������� ������ ����� �������� ����� �������� ��������� ����������, ����� ������� ����� �� ��������� � ������ �����.
            Console.WriteLine(line);
            text.ReplaceWords(0, 5, "!!!!");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}




