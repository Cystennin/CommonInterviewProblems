using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Raven.Personal.CommonInterviewProblems.Algorithms;

namespace Raven.Personal.CommonInterviewProblems.Tests.Algorithms.Actual
{
    [TestClass]
    public class EquilibriumIndexTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenCalledWithNullArray_throwsArgumentNullException()
        {
            List<int> inputArray = null;
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenCalledWithNullArray_throwsArgumentOutOfRangeException()
        {
            List<int> inputArray = new List<int>();
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
        }

        [TestMethod]
        public void WhenCalledWithSingleElementArray_returnsListWithSingleElementOfValueZero()
        {
            List<int> inputArray = new List<int>() { 1 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices[0], 0);
        }

        [TestMethod]
        public void WhenCalledWith_0_1_returns_EmptyList()
        {
            List<int> inputArray = new List<int>() { 0, 1 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 0);
        }

        [TestMethod]
        public void WhenCalledWith_0_0_returns_0_1()
        {
            List<int> inputArray = new List<int>() { 0, 0 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 2);
            Assert.AreEqual(equilibriumIndices[0], 0);
            Assert.AreEqual(equilibriumIndices[1], 1);
        }

        [TestMethod]
        public void WhenCalledWith_0_1_1_returns_1()
        {
            List<int> inputArray = new List<int>() { 0, 1, 1 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 1);
            Assert.AreEqual(equilibriumIndices[0], 1);
        }

        [TestMethod]
        public void WhenCalledWith_1_1_0_returns_0()
        {
            List<int> inputArray = new List<int>() { 1, 1, 0 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 1);
            Assert.AreEqual(equilibriumIndices[0], 0);
        }

        [TestMethod]
        public void WhenCalledWith_1_1_2_returns_1()
        {
            List<int> inputArray = new List<int>() { 1, 1, 2 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 1);
            Assert.AreEqual(equilibriumIndices[0], 1);
        }

        [TestMethod]
        public void WhenCalledWith_1_1_2_0_returns_1()
        {
            List<int> inputArray = new List<int>() { 1, 1, 2, 0 };
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 1);
            Assert.AreEqual(equilibriumIndices[0], 1);
        }

        [TestMethod]
        public void WhenCalledWith_1_1_0_2_returns_1_2()
        {
            List<int> inputArray = new List<int>() { 1, 1, 0, 2};
            List<int> equilibriumIndices = inputArray.getEquilibriumIndices();
            Assert.AreEqual(equilibriumIndices.Count, 2);
            Assert.AreEqual(equilibriumIndices[0], 1);
            Assert.AreEqual(equilibriumIndices[1], 2);
        }
    }
}