using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class NodeInterfaceExtensions_LengthTests
    {
        [TestMethod]
        public void WhenLengthIsCalled_WithSingleElementList_ReturnsOne()
        {
            string[] valueList = { "A" };
            INode<string> list = valueList.CreateFrom();
            Assert.AreEqual(1, list.Length());
        }

        [TestMethod]
        public void WhenLengthIsCalled_WithTwoElementList_ReturnsTwo()
        {
            string[] valueList = { "A" , "B"};
            INode<string> list = valueList.CreateFrom();
            Assert.AreEqual(2, list.Length());
        }
    }
}
