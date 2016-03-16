using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures
{
    [TestClass]
    public class NodeInterfaceExtensions_LoopDetectedTests
    {
        [TestMethod]
        public void whenLoopDetectedCalled_OnListWithSingleNode_ReturnsFalse()
        {
            INode<string> nodeA = Node<string>.CreateNode("A");
            Assert.IsFalse(nodeA.LoopDetected());
        }

        [TestMethod]
        public void whenLoopDetectedCalled_OnListAB_ReturnsFalse()
        {
            INode<string> nodeA = Node<string>.CreateNode("A");
            INode<string> nodeB = Node<string>.CreateNode("B");
            nodeA.InsertChild(ref nodeB);
            Assert.IsFalse(nodeA.LoopDetected());
        }

        [TestMethod]
        public void whenLoopDetectedCalled_OnListAA_ReturnsTrue()
        {
            INode<string> nodeA = Node<string>.CreateNode("A");
            nodeA.Child = nodeA;
            Assert.IsTrue(nodeA.LoopDetected());
        }

        [TestMethod]
        public void whenLoopDetectedCalled_OnListABA_ReturnsTrue()
        {
            INode<string> nodeA = Node<string>.CreateNode("A");
            INode<string> nodeB = Node<string>.CreateNode("B");
            nodeA.InsertChild(ref nodeB);
            nodeB.Child = nodeA;
            Assert.IsTrue(nodeA.LoopDetected());
        }

        [TestMethod]
        public void whenLoopDetectedCalled_OnListABB_ReturnsTrue()
        {
            INode<string> nodeA = Node<string>.CreateNode("A");
            INode<string> nodeB = Node<string>.CreateNode("B");
            nodeA.InsertChild(ref nodeB);
            nodeB.Child = nodeB;
            Assert.IsTrue(nodeA.LoopDetected());
        }
    }
}
