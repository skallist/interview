using System.Collections.Generic;
using System.Linq;
using Anagrams.core.Contracts;

namespace Anagrams.core
{
    /// <summary>
    /// Solves anagram problem in O(n²)
    /// </summary>
    public class BadAnagramCounter : IAnagramCounter
    {
        public int NumberOfAnagrams(IEnumerable<string> words, bool ignoreCase)
        {
            var anagrams = GetAnagrams(words.ToList());
            return anagrams.Count;
        }
      
        private List<string> GetAnagrams(List<string> words)
        {
            var anagrams = new List<string>();

            for (int i = 0; i < words.Count(); i++)
            {
                for (int j = i; j < words.Count(); j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    bool a = AnagramUtils.BubbleSort(words[i]) == AnagramUtils.BubbleSort(words[j]);
                    if (a == true)
                    {
                        anagrams.Add(words[j]);
                    }
                }
            }

            return anagrams;
        }
    }
}