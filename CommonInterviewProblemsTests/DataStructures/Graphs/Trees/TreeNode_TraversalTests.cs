using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.Tests.DataStructures.Graphs.Trees
{
    [TestClass]
    public class TreeNode_TraveralTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void whenTraverseIsCalled_WithNullParameter_returnsNull()
        {
            ITreeNode<string> rootNode = null;
            List<string> returnedList = rootNode.Traverse();
            
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithoutChildren_returnValueIsNonNull()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            List<string> returnedList = rootNode.Traverse();
            Assert.IsNotNull(returnedList);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithoutChildren_returnValueHasLengthOfOne()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            List<string> returnedList = rootNode.Traverse();
            Assert.AreEqual(returnedList.Count, 1);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithoutChildren_FirstElementOfReturnValue_HasSameValueAsInputNode()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            List<string> returnedList = rootNode.Traverse();
            Assert.AreEqual(returnedList[0], "root");
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithLeftChildOnly_ReturnListHasTwoValues()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("C");
            ITreeNode<string> leftNode = TreeNode<string>.Create("L");
            ITreeNode<string> tree = rootNode.SetLeft(leftNode);
            List<string> returnedList = rootNode.Traverse();
            Assert.AreEqual(2, returnedList.Count);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithLeftChildOnly_ReturnListEquals_L_C()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("C");
            ITreeNode<string> leftNode = TreeNode<string>.Create("L");
            ITreeNode<string> tree = rootNode.SetLeft(leftNode);
            List<string> returnedList = rootNode.Traverse();
            List<string> expectedList = new List<string>() { "L", "C" };
            bool areEqual = expectedList.All(returnedList.Contains) && (expectedList.Count == returnedList.Count);
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithLeftAndRightChild_ReturnListEquals_L_C_R()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("C");
            ITreeNode<string> leftNode = TreeNode<string>.Create("L");
            ITreeNode<string> rightNode = TreeNode<string>.Create("R");
            ITreeNode<string> tree = rootNode.SetLeft( leftNode);
            tree = tree.SetRight(rightNode);
            List<string> returnedList = rootNode.Traverse();
            List<string> expectedList = new List<string>() { "L", "C", "R" };
            bool areEqual = expectedList.All(returnedList.Contains) && (expectedList.Count == returnedList.Count);
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWithlLlRLCR_ReturnListEquals_LRLCR()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("C");
            ITreeNode<string> leftNode = TreeNode<string>.Create("L");
            ITreeNode<string> rightNode = TreeNode<string>.Create("R");
            ITreeNode<string> tree = rootNode.SetLeft(leftNode);
            tree = rootNode.SetRight(rightNode);
            tree = rootNode.Left.SetLeft(TreeNode<string>.Create("lL"));
            tree = rootNode.Left.SetRight(TreeNode<string>.Create("lR"));
            List<string> returnedList = rootNode.Traverse();
            List<string> expectedList = new List<string>() { "lL","lR","L", "C", "R" };
            bool areEqual = expectedList.All(returnedList.Contains) && (expectedList.Count == returnedList.Count);
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void whenTraverseIsCalled_OnNodeWith_LL_RR_L_C_R_RL_RR_ReturnsSame()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("C");
            rootNode.SetLeft(TreeNode<string>.Create("L"));
            rootNode.SetRight(TreeNode<string>.Create("R"));
            rootNode.Left.SetLeft(TreeNode<string>.Create("LL"));
            rootNode.Left.SetRight(TreeNode<string>.Create("LR"));
            rootNode.Right.SetLeft(TreeNode<string>.Create("RL"));
            rootNode.Right.SetRight(TreeNode<string>.Create("RR"));
            List<string> returnedList = rootNode.Traverse();
            List<string> expectedList = new List<string>() { "LL", "RR", "L", "C", "R", "RL","RR" };
            bool areEqual = expectedList.All(returnedList.Contains) && (expectedList.Count == returnedList.Count);
            Assert.IsTrue(areEqual);
        }

    }
}
