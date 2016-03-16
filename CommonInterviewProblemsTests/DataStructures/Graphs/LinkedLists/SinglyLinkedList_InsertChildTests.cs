using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class SinglyLinkedList_InsertChildTests
    {
        [TestMethod]
        public void whenInsertChildIsCalled_OnANodeWithoutChildren_assertLengthIsTwo()
        {
            INode<string> list = Node<string>.CreateNode("A");
            INode<string> nodeB = Node<string>.CreateNode("B");
            list.InsertChild(ref nodeB);
            Assert.AreEqual(2, list.Length());
        }

        [TestMethod]
        public void whenInsertChildIsCalled_OnANodeWithoutChildren_assertThatLastChildValueEqualsTheValueOfTheInsertedNode()
        {
            INode<string> list = Node<string>.CreateNode("A");
            INode<string> nodeB = Node<string>.CreateNode("B");
            list.InsertChild(ref nodeB);
            Assert.AreEqual(nodeB.Value, list?.GetLastChild()?.Value);
        }

        [TestMethod]
        public void whenInsertChildIsCalled_OnTheFirstNodeOfATwoElementList_assertLengthIsThree()
        {
            string[] arrayList = { "A", "C" };
            INode<string> list = arrayList.ToSinglyLinkedList();
            INode<string> nodeB = Node<string>.CreateNode("B");
            list.InsertChild(ref nodeB);
            Assert.AreEqual(3, list.Length());
        }

        [TestMethod]
        public void whenInsertChildIsCalled_OnTheFirstNodeOfATwoElementList_assertThatSecondChildValueEqualsTheValueOfTheInsertedNode()
        {
            string[] arrayList = { "A", "C" };
            INode<string> list = arrayList.ToSinglyLinkedList();
            INode<string> nodeB = Node<string>.CreateNode("B");
            list.InsertChild(ref nodeB);
            Assert.AreEqual(nodeB.Value, list?.Child?.Value);
        }

        [TestMethod]
        public void whenInsertChildIsCalled_OnTheFirstNodeOfATwoElementList_assertThatLastChildValueRemainsTheSame()
        {
            string[] arrayList = { "A", "C" };
            INode<string> list = arrayList.ToSinglyLinkedList();
            INode<string> nodeB = Node<string>.CreateNode("B");
            list.InsertChild(ref nodeB);
            Assert.AreEqual("C", list?.GetLastChild()?.Value);
        }

        [TestMethod]
        public void whenInsertChildIsCalledwithATwoElementNode_OnANodeWithoutChildren_assertLengthIsTwo()
        {
            INode<string> list = Node<string>.CreateNode("A");
            string[] arrayB = { "B", "C" };
            INode<string> nodeB = arrayB.ToSinglyLinkedList();
            list.InsertChild(ref nodeB);
            Assert.AreEqual(2, list.Length());
        }
    }
}
