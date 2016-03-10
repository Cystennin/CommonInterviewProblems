using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class ReverseAStringIterativelyTests
    {
        [TestMethod]
        public void SimpleCase_EvenNumberOfChars()
        {
            string ABCD = "ABCD";
            string result = ReverseAStringIteratively.Execute(ABCD);
            Assert.AreEqual("DCBA", result);
        }

        [TestMethod]
        public void SimpleCase_OddNumberOfChars()
        {
            string ABCDE = "ABCDE";
            string result = ReverseAStringIteratively.Execute(ABCDE);
            Assert.AreEqual("EDCBA", result);
        }

        [TestMethod]
        public void SimpleCase_Palindrome()
        {
            string ABCBA = "ABCBA";
            string result = ReverseAStringIteratively.Execute(ABCBA);
            Assert.AreEqual(ABCBA, result);
        }

        [TestMethod]
        public void SimpleCase_EmptyString()
        {
            string emptyString = string.Empty;
            string result = ReverseAStringIteratively.Execute(emptyString);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void SimpleCase_StringWithSingleCharacter()
        {
            string singleCharString = "A";
            string result = ReverseAStringIteratively.Execute(singleCharString);
            Assert.AreEqual(singleCharString, result);
        }
    }
}
