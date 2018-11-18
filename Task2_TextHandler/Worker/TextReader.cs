using System.IO;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler.Worker
{
    public class TextReader : IFileReader
    {
        public string FileName { get; }


        public TextReader(string fileName)
        {
            FileName = fileName;
        }

        public string Read()
        {
            string text;
            using (var stream = new FileStream(FileName, FileMode.Open))                                                                                     
            {
                var reader = new StreamReader(stream);
                text = reader.ReadToEnd();
            }

            return text.Replace("\r\n", " ");
        }
    }
}