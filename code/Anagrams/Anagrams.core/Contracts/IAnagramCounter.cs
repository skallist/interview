using System.Collections.Generic;

namespace Anagrams.core.Contracts
{
    public interface IAnagramCounter
    {
        int NumberOfAnagrams(IEnumerable<string> words, bool ignoreCase);
    }
}
