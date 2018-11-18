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
            //1     Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
            Console.WriteLine(line);
            foreach (var x in text.SortSentences()) Console.WriteLine(x);
            //2     Во всех вопросительных предложениях текста найти и напечатать без повторений слова заданной  длины.
            Console.WriteLine(line);
            foreach (var x in text.FindWordsOfPredeterminedLength(7)) Console.WriteLine(x);
            //3     Из текста удалить все слова заданной длины, начинающиеся на согласную букву.
            Console.WriteLine(line);
            var copyOfText = (Text) text.Clone();
            copyOfText.RemoveWordsWithFirstConsonant(7);
            Console.WriteLine(copyOfText);
            //4      В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова.
            Console.WriteLine(line);
            text.ReplaceWords(0, 5, "!!!!");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}




