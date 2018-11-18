using System.Collections.Generic;

namespace Task2_TextHandler.Interfaces
{
    public interface ISentence
    {
        IEnumerable<ISentence> SortSentences();
    }
}