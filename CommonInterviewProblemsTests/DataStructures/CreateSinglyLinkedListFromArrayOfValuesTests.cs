using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class CreateSinglyLinkedListFromArrayOfValuesTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void whenCreateFromArrayExtensionCalled_WithNullValueInArray_ArgumentNullExceptionIsThrown()
        {
            string[] valueList = { null };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.IsNull(list.Child);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithEmptyValueArray_EmptyListIsCreated()
        {
            string[] valueList = { };
            INode<string> emptyList = valueList.ToSinglyLinkedList();
            Assert.IsNull(emptyList);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithSingleValueInArray_ListWithSingleNodeIsCreated()
        {
            string[] valueList = { "A" };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithSingleValueInArray_ValueOfRootNodeMatchesFirstValueOfArray()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.AreEqual<string>(A, list?.Value);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithSingleValueInArray_ChildOfRootNodeIsNull()
        {
            string A = "A";
            string[] valueList = { A };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.IsNull(list.Child);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithTwoValuesInArray_ValueOfRootNodeMatchesFirstValueOfArray()
        {
            string A = "A";
            string[] valueList = { A , "B"};
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.AreEqual<string>(A, list.Value);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithTwoValuesInArray_ChildOfRootNodeIsNotNull()
        {
            string A = "A";
            string[] valueList = { A, "B" };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.IsNotNull(list?.Child);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithTwoValuesInArray_ValueOfChildOfRootNodeIsNotNull()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.IsNotNull(list?.Child?.Value);
        }

        [TestMethod]
        public void whenCreateFromArrayExtensionCalled_WithTwoValuesInArray_ValueOfChildOfRootNodeMatchesSecondValueOfArray()
        {
            string B = "B";
            string[] valueList = { "A", B };
            INode<string> list = valueList.ToSinglyLinkedList();
            Assert.AreEqual<string>(B, list?.Child?.Value);
        }
    }
}
