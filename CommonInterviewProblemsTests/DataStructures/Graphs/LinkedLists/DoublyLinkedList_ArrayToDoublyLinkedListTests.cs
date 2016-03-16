using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class DoublyLinkedList_ArrayToDoublyLinkedListTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenToDoublyLinkedListIsCalled_WithNullValueInArray_ArgumentNullExceptionIsThrown()
        {
            string[] valueList = { null };
            INode<string> list = valueList.ToDoublyLinkedList();
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithEmptyValueArray_EmptyListIsCreated()
        {
            string[] valueList = { };
            INode<string> emptyList = valueList.ToDoublyLinkedList();
            Assert.IsNull(emptyList);
        }


        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithSingleValueInArray_ListWithSingleNodeIsCreated()
        {
            string[] valueList = { "A" };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.IsNotNull(list);
        }


        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithSingleValueInArray_ValueOfRootNodeMatchesFirstValueOfArray()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.AreEqual<string>(A, list?.Value);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithSingleValueInArray_ChildOfRootNodeIsNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.IsNull(list.Child);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithSingleValueInArray_ParentOfRootNodeIsNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.IsNull(list.Parent);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithTwoValuesInArray_ValueOfRootNodeMatchesFirstValueOfArray()
        {
            string A = "A";
            string[] valueList = { A, "B" };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.AreEqual<string>(A, list.Value);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithTwoValuesInArray_ChildOfRootNodeIsNotNull()
        {
            string A = "A";
            string[] valueList = { A, "B" };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.IsNotNull(list?.Child);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithTwoValuesInArray_ValueOfChildOfRootNodeIsNotNull()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.IsNotNull(list?.Child?.Value);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithTwoValuesInArray_ValueOfChildOfRootNodeMatchesSecondValueOfArray()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.AreEqual<string>(B, list?.Child?.Value);
        }

        [TestMethod]
        public void WhenToDoublyLinkedListIsCalled_WithTwoValuesInArray_ValueOfParentOfChildOfRootNodeMatchesValueOfRoot()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.ToDoublyLinkedList();
            Assert.AreEqual<string>("A", list?.Child?.Parent?.Value);
        }
    }
}
