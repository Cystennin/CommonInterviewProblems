using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class SinglyLinkedList_RemoveChildTests
    {
        [TestMethod]
        public void whenRemoveChildIsCalled_OnRootWithoutChildren_assertLengthIsOne()
        {
            INode<string> list = Node<string>.CreateNode("A");
            list.RemoveChild();
            Assert.AreEqual(1, list.Length());
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnRootWithoutChildren_assertValueOfRootIsUnchanged()
        {
            INode<string> list = Node<string>.CreateNode("A");
            list.RemoveChild();
            Assert.AreEqual("A", list.Value);
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnRootWithASingleChild_assertLengthIsOne()
        {
            string[] arrayA = { "A", "B" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            list.RemoveChild();
            Assert.AreEqual(1, list.Length());
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnRootWithASingleChild_assertValueOfRootNodeIsUnchanged()
        {
            string[] arrayA = { "A", "B" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            list.RemoveChild();
            Assert.AreEqual("A", list.Value);
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnChildOfRootWithASingleChild_assertLengthIsTwo()
        {
            string[] arrayA = { "A", "B" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            list.Child.RemoveChild();
            Assert.AreEqual(2, list.Length());
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnChildOfRootWithASingleChild_assertValueOfChildOfRootNodeIsUnchanged()
        {
            string[] arrayA = { "A", "B" };
            INode<string> list = arrayA.ToSinglyLinkedList();
            list.Child.RemoveChild();
            Assert.AreEqual("B", list.Child.Value);
        }

        [TestMethod]
        public void whenRemoveChildIsCalled_OnNodeBOfListABC_assertResulingListEqualsAC()
        {
            string[] arrayA = { "A", "B", "C"};
            INode<string> list = arrayA.ToSinglyLinkedList();
            list.RemoveChild();
            Assert.AreEqual("A->C->NULL", list.ToString());
        }
    }
}
