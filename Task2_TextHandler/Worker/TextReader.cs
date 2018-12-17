using System;
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
            string text = string.Empty;
            try
            {
                using (var stream = new FileStream(FileName, FileMode.Open))
                {
                    var reader = new StreamReader(stream);
                    text = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }

            return text;
        }
    }
}