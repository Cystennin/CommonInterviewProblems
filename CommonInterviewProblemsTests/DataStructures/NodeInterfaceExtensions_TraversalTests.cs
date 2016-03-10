using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class NodeInterfaceExtensions_TraversalTests
    {
        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithSingleValuesInArray_whenLastChildIsCalled_ResultIsNotNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.CreateFrom();
            Assert.IsNotNull(list.GetLastChild());
        }

        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithSingleValuesInArray_whenLastChildIsCalled_ResultsValueIsNotNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.CreateFrom();
            Assert.IsNotNull(list.GetLastChild()?.Value);
        }

        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithSingleValuesInArray_whenLastChildIsCalled_ResultsValueMatchesFirstElementOfArray()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.CreateFrom();
            Assert.AreEqual(A, list.GetLastChild().Value);
        }

        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithSingleValuesInArray_whenLastChildIsCalled_ResultsChildIsNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.CreateFrom();
            Assert.IsNull(list.GetLastChild().Child);
        }


        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithTwoValuesInArray_whenLastChildIsCalled_ResultIsNotNull()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.CreateFrom();
            Assert.IsNotNull(list.GetLastChild());
        }

        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithTwoValuesInArray_whenLastChildIsCalled_ResultsChildIsNull()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.CreateFrom();
            Assert.IsNull(list.GetLastChild().Child);
        }

        [TestMethod]
        public void givenCreateFromArrayExtensionCalledWithTwoValuesInArray_whenLastChildIsCalled_ResultsValueMatchesLastValueOfArray()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.CreateFrom();
            Assert.AreEqual(B, list.GetLastChild().Value);
        }
    }
}
