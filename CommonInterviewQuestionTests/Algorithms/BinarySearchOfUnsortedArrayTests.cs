using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class BinarySearchOfUnsortedArrayTests
    {
        [TestMethod]
        public void FailingSearchInSingleElementArray()
        {
            string A = "A";
            string[] arrayToSearch = { "B" };
            int indexOfA = BinarySearchOfUnsortedArray<String>.Execute(A, arrayToSearch);
            Assert.AreEqual(-1, indexOfA);
        }

        [TestMethod]
        public void SuccessfulSearchInSingleElementArray()
        {
            string A = "A";
            string[] arrayToSearch = { "A" };
            int indexOfA = BinarySearchOfUnsortedArray<String>.Execute(A, arrayToSearch);
            Assert.AreEqual(0, indexOfA);
        }

        [TestMethod]
        public void FailingSearchInTwoElementArray()
        {
            string B = "B";
            string[] arrayToSearch = { "A", "C" };
            int indexOfB = BinarySearchOfUnsortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInTwoElementArray_FirstElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { B, "C" };
            int indexOfB = BinarySearchOfUnsortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(0, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInTwoElementArray_LastElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { "A", B };
            int indexOfB = BinarySearchOfUnsortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInThreeElementArray_MiddleElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { "A", B, "C" };
            int indexOfB = BinarySearchOfUnsortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInThreeElementArray_LastElementMatches()
        {
            string C = "C";
            string[] arrayToSearch = { "A", "B", C };
            int indexOfB = BinarySearchOfUnsortedArray<String>.Execute(C, arrayToSearch);
            Assert.AreEqual(2, indexOfB);
        }

    }
}
