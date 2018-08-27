using Anagrams.core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Anagrams.test
{
    [TestClass]
    public class AnagramTests
    {
        private IAnagramSolver _solver;
        [TestMethod]
        public void AnagramSolver_NumberOfAnagrams_Returns_Zero_For_Empty_List()
        {
            var words = new string[] { };

            _solver.NumberOfAnagrams(words).ShouldBe(0);
        }

        [TestMethod]
        public void AnagramSolver_NumberOfAnagrams_Should_Equal_One_For_Dummy_List_Containing_Two_Elements()
        {
            var words = new string[] { "test", "sett" };

            _solver.NumberOfAnagrams(words).ShouldBe(1);
        }


    }
}
