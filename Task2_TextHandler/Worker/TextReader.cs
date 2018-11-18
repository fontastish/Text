using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task2_TextHandler.Interfaces;

namespace Task2_TextHandler
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
            using (var stream = new FileStream(FileName, FileMode.Open))   // filestream не управляемый ресурс,
                                                                           // поэтому мы должны его задиспосзит(прочитать подробнее про using)
            {
                var reader = new StreamReader(stream);
                text = reader.ReadToEnd();
            }

            return text.Replace("\r\n", " ");
        }
    }
}
