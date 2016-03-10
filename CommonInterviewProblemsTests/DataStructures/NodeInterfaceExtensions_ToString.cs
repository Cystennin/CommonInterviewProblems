using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class NodeInterfaceExtensions_ToString
    {
        [TestMethod]
        public void WhenToStringIsCalled_WithSingleElementList_ReturnsA_Arrow_Null()
        {
            string[] valueList = { "A" };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.AreEqual("A->NULL", list.ToString());
        }


        [TestMethod]
        public void WhenToStringIsCalled_WithTwoElementList_ReturnsA_Arrow_B_Arrow_Null()
        {
            string[] valueList = { "A", "B" };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.AreEqual("A->B->NULL", list.ToString());
        }
    }
    
}
