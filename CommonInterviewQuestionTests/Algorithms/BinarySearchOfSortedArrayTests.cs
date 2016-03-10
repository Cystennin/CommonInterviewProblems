using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class BinarySearchOfSortedArrayTests
    {
        [TestMethod]
        public void FailingSearchInSingleElementArray()
        {
            string A = "A";
            string[] arrayToSearch = { "B" };
            int indexOfA = BinarySearchOfSortedArray<String>.Execute(A, arrayToSearch);
            Assert.AreEqual(-1, indexOfA);
        }

        [TestMethod]
        public void SuccessfulSearchInSingleElementArray()
        {
            string A = "A";
            string[] arrayToSearch = { "A" };
            int indexOfA = BinarySearchOfSortedArray<String>.Execute(A, arrayToSearch);
            Assert.AreEqual(0, indexOfA);
        }

        [TestMethod]
        public void FailingSearchInTwoElementArray()
        {
            string B = "B";
            string[] arrayToSearch = { "A", "C" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInTwoElementArray_FirstElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { B, "C" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(0, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInTwoElementArray_LastElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { "A", B };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInThreeElementArray_MiddleElementMatches()
        {
            string B = "B";
            string[] arrayToSearch = { "A", B, "C" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute(B, arrayToSearch);
            Assert.AreEqual(1, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInThreeElementArray_LastElementMatches()
        {
            string C = "C";
            string[] arrayToSearch = { "A", "B", C };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute(C, arrayToSearch);
            Assert.AreEqual(2, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInMultiElementArray_SecondToLastElementMatches()
        {
            string[] arrayToSearch = { "A", "B", "F", "H", "K","Z"};
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("K", arrayToSearch);
            Assert.AreEqual(4, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInMultiElementArray_LastElementMatches()
        {
            string[] arrayToSearch = { "A", "B", "F", "H", "K", "Z" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("Z", arrayToSearch);
            Assert.AreEqual(5, indexOfB);
        }

        [TestMethod]
        public void SuccessfulSearchInMultiElementArray_NextToMiddleElementMatches()
        {
            string[] arrayToSearch = { "A", "B", "F", "H", "K", "Z" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("F", arrayToSearch);
            Assert.AreEqual(2, indexOfB);
        }

        [TestMethod]
        public void FailingSearchForA()
        {
            string[] arrayToSearch = { "B", "C", "F", "H", "K", "Y" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("A", arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }

        [TestMethod]
        public void FailingSearchForZ()
        {
            string[] arrayToSearch = { "B", "C", "F", "H", "K", "Y" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("Z", arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }

        [TestMethod]
        public void FailingSearchForE()
        {
            string[] arrayToSearch = { "A", "C", "F", "H", "K", "Y" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("E", arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }
        [TestMethod]
        public void FailingSearchForB()
        {
            string[] arrayToSearch = { "A", "C", "F", "H", "K", "Y" };
            int indexOfB = BinarySearchOfSortedArray<String>.Execute("B", arrayToSearch);
            Assert.AreEqual(-1, indexOfB);
        }
    }
}
