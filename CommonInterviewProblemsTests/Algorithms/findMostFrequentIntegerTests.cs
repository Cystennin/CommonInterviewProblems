using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.Algorithms;


namespace Raven.Personal.CommonInterviewProblems.Tests
{
    [TestClass]
    public class FindMostFrequentIntegerTests
    {
        public FindMostFrequentIntegerTests()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenNullArrayIsPassedIn_ThrowsException()
        {
            int[] arrayToTest = null;
            FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenEmptyArrayIsPassedIn_ThrowsException()
        {
            int[] arrayToTest = new int[0];
            FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
        }

        [TestMethod]
        public void WhenArrayWithSingleElementIsPassedIn()
        {
            int expectedResult = 1;
            int[] arrayToTest = new int[] { 1 };
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArrayMostFrequentElementIsPassedIn()
        {
            int expectedResult = 1;
            int[] arrayToTest = new int[] { 1, 1, 0 };
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArrayMostFrequentElementIsPassedInUsingReverseOrder()
        {
            int expectedResult = 1;
            int[] arrayToTest = new int[] { 0, 1, 1};
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArrayMostFrequentElementIsPassedInUsingNoOrder()
        {
            int expectedResult = 1;
            int[] arrayToTest = new int[] { 1, 0, 1 };
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArraysMostFrequentIntegerPassedInIsLexographicallyTheSmallest()
        {
            int expectedResult = 0;
            int[] arrayToTest = new int[] { 0, 0, 1, 0, 0 };
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArraysMostFrequentIntegerAreTheLastElementsOfTheArray()
        {
            int expectedResult = 3;
            int[] arrayToTest = new int[] { 3,2,1,3,2,3,0 };
            Int32 actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenArraysArrayOfStringsPassedIn()
        {
            String a = "a";
            String b = "b";
            String[] arrayToTest = new String[] { a, a, b, a, a};
            String actualResult = FindMostFrequentIntegerInAnArray.findMostFrequentInteger(arrayToTest);
            Assert.AreEqual(a , actualResult);
        }
    }
}
