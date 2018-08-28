using System.Linq;
using Anagrams.core;
using Anagrams.core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Anagrams.test
{
    [TestClass]
    public class AnagramTests
    {
        private IAnagramCounter _anagramCounter;

        [TestMethod]
        public void AnagramFileReader_GetWords_Returns_Word_List_For_Anagrams_Text_File()
        {
            var path = @"resources/anagrams.txt";
            var words = AnagramFileReader.GetWords(path);

            words.Count().ShouldBe(18);
        }

        [TestMethod]
        public void AnagramCounter_NumberOfAnagrams_Returns_Zero_For_Empty_List()
        {
            var words = new string[] { };

            _anagramCounter.NumberOfAnagrams(words, ignoreCase: true).ShouldBe(0);
        }

        [TestMethod]
        public void AnagramCounter_NumberOfAnagrams_Should_Equal_Two_For_Dummy_List_Containing_Two_Anagrams()
        {
            // todo: make dummy list with 2 anagrams
            var words = new[] { "" };

            _anagramCounter.NumberOfAnagrams(words, ignoreCase: true).ShouldBe(2);
        }
    }
}
