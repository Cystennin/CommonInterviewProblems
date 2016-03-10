using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class ReverseAStringRecursivelyTests
    {
        [TestMethod]
        public void SimpleCase_EvenNumberOfChars()
        {
            string ABCD = "ABCD";
            string result = ReverseAStringRecursively.Execute(ABCD);
            Assert.AreEqual("DCBA", result);
        }

        [TestMethod]
        public void SimpleCase_OddNumberOfChars()
        {
            string ABCDE = "ABCDE";
            string result = ReverseAStringRecursively.Execute(ABCDE);
            Assert.AreEqual("EDCBA", result);
        }

        [TestMethod]
        public void SimpleCase_Palindrome()
        {
            string ABCBA = "ABCBA";
            string result = ReverseAStringRecursively.Execute(ABCBA);
            Assert.AreEqual(ABCBA, result);
        }

        [TestMethod]
        public void SimpleCase_EmptyString()
        {
            string emptyString = string.Empty;
            string result = ReverseAStringRecursively.Execute(emptyString);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void SimpleCase_StringWithSingleCharacter()
        {
            string singleCharString = "A";
            string result = ReverseAStringRecursively.Execute(singleCharString);
            Assert.AreEqual(singleCharString, result);
        }
    }
}
