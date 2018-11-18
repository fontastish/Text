using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_TextHandler.Interfaces
{
    public interface ISentence
    {
        IEnumerable<ISentence> SortSentences();
    }
}