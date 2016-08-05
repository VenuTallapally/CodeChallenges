using System;
using CodeChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallengeTests
{
    [TestClass]
    public class CodeChallenge01Aug16Tests
    {
        [TestMethod]
        public void MustReturnIndex()
        {
            var codeChallenge = new CodeChallenge01Aug16();
            var numbers = new []{ 4,8,9,7,5,5,23 };

            var index = codeChallenge.FindIndex(numbers);
            Console.WriteLine(index);
            Console.WriteLine(index == -1 ? "TEST CASE: FAILED" : "TEST CASE: PASSED");
        }
    }
}
