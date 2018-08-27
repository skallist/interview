using System.Collections.Generic;

namespace Anagrams.core.Contracts
{
    public interface IAnagramSolver
    {
        int NumberOfAnagrams(IEnumerable<string> words);
    }
}
