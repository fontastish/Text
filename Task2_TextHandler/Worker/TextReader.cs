using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_TextHandler
{
    public class TextReader : IFileReader
    {
        public string FileName { get; set; }

        TextReader(string fileName)
        {
            FileName = fileName;
        }

        public List<string> Read()
        {
            var strArray = File.ReadAllLines(FileName);
            List<string> textList = strArray.ToList();
            //StreamReader readFile = new StreamReader(FileName);
            //string tempString = string.Empty;
            // while (!readFile.EndOfStream)
            // {
            //     tempString = readFile.ReadLine();
            //     textList.Add(tempString);
            // }
            // readFile.Close();
            return textList;
        }
    }
}
