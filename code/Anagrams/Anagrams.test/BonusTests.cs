using Anagrams.core;
using Anagrams.core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Anagrams.test
{
    [TestClass]
    public class BonusTests
    {
        private readonly IAnagramCounter _anagramCounter;

        [TestMethod]
        [Timeout(20_000)]
        public void AnagramCounter_NumberOfAnagrams_Returns_Anagram_Count_In_A_Timely_Manner()
        {
            var path = @"resources/wordlist.txt";
            var words = AnagramFileReader.GetWords(path);

            var anagramCount = _anagramCounter.NumberOfAnagrams(words, ignoreCase: false);
            anagramCount.ShouldBe(30404);
        }
    }
}
