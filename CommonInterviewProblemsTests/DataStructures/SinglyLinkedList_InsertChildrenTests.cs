using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class SinglyLinkedList_InsertChildrenTests
    {
        [TestMethod]
        public void whenInsertChildrenIsCalledwithATwoElementNode_OnANodeWithoutChildren_assertLengthIsTwo()
        {
            INode<string> list = Node<string>.CreateNode("A");
            string[] arrayB = { "B", "C" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.InsertChildren(ref nodeB);
            Assert.AreEqual(3, list.Length());
        }

        [TestMethod]
        public void whenInsertChildrenIsCalledwithATwoElementNode_OnANodeWithoutChildren_assertThatLastChildValueEqualsTheLastChildValueOfTheInsertedNode()
        {
            INode<string> list = Node<string>.CreateNode("A");
            string[] arrayB = { "B", "C" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.InsertChildren(ref nodeB);
            Assert.AreEqual("C", list?.GetLastChild()?.Value);
        }

        [TestMethod]
        public void whenInsertChildIsCalled_OnTheFirstNodeOfATwoElementList_assertLengthIsFour()
        {
            string[] arrayA = { "A", "D" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            string[] arrayB = { "B", "C" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.InsertChildren(ref nodeB);
            Assert.AreEqual(4, list.Length());
        }

        [TestMethod]
        public void whenInsertChildrenIsCalled_WithNodeBC_OnNodeAD_assertResultantListIsABCD()
        {
            string[] arrayA = { "A", "D" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            string[] arrayB = { "B", "C" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.InsertChildren(ref nodeB);
            Assert.AreEqual("A->B->C->D->NULL", list.ToString());
        }

        [TestMethod]
        public void whenInsertChildrenIsCalled_WithNodeCD_OnChileOfNodeAB_assertResultantListIsABCD()
        {
            string[] arrayA = { "A", "B" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            string[] arrayB = { "C", "D" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.Child.InsertChildren(ref nodeB);
            Assert.AreEqual("A->B->C->D->NULL", list.ToString());
        }

    }
}
