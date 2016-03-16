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
    public class TreeNodeTests
    {
        [TestMethod]
        public void whenTreeNodeFactoryIsCalled_ValidObjectIsReturned()
        {
            ITreeNode<string> treeNode = TreeNode<string>.Create(null);
            Assert.IsNotNull(treeNode);
        }

        [TestMethod]
        public void whenTreeNodeFactoryIsCalledWithNonNullParameter_ReturnedObjectValueMatchesParameter()
        {
            string expected = "expected";
            ITreeNode<string> treeNode = TreeNode<string>.Create(expected);
            Assert.AreEqual(expected, treeNode.Value);
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNullParameter_ReturnValueIsRootValue()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("A");
            ITreeNode<string> leftNode = null;
            ITreeNode<string> returnedNode = rootNode.SetLeft<string>(ref leftNode);
            Assert.IsTrue(ReferenceEquals(rootNode, returnedNode));
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNullParameter_LeftChildIsNull()
        {
            ITreeNode<string> treeNode = TreeNode<string>.Create("A");
            ITreeNode<string> leftNode = null;
            treeNode.SetLeft<string>(ref leftNode);
            Assert.IsNull(treeNode.Left);
        }


        [TestMethod]
        public void whenSetLeftIsCalled_WithNullParameter_ReturnReferenceIsSameAsRootReference()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("A");
            ITreeNode<string> leftNode = null;
            ITreeNode<string> returnedNode = rootNode.SetLeft<string>(ref leftNode);
            Assert.IsTrue(ReferenceEquals(rootNode, returnedNode));
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNullParameter_ReturnReferenceIsSameAsRootReference()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("A");
            ITreeNode<string> rightNode = null;
            ITreeNode<string> returnedNode = rootNode.SetRight<string>(ref rightNode);
            Assert.IsTrue(ReferenceEquals(rootNode, returnedNode));
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNonNullParameter_ReturnReferenceIsSameAsRootReference()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> leftNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetLeft<string>(ref leftNode);
            Assert.IsTrue(ReferenceEquals(rootNode, returnedNode));
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNonNullParameter_ReturnReferenceIsSameAsRootReference()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = TreeNode<string>.Create("right");
            ITreeNode<string> returnedNode = rootNode.SetRight<string>(ref rightNode);
            Assert.IsTrue(ReferenceEquals(rootNode, returnedNode));
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNullParameter_RightChildIsNull()
        {
            ITreeNode<string> treeNode = TreeNode<string>.Create("A");
            ITreeNode<string> rightNode = null;
            ITreeNode<string> returnedNode = treeNode.SetRight(ref rightNode);
            Assert.IsNull(returnedNode.Right);
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNonNullParameter_LeftChildIsNonNull()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> leftNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetLeft(ref leftNode);
            Assert.IsNotNull(returnedNode.Left);
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNonNullParameter_LeftChildsReferenceIsSameAsParameters()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> leftNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetLeft(ref leftNode);
            Assert.IsTrue(object.ReferenceEquals(returnedNode.Left, leftNode));
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNonNullParameter_RightChildIsNonNull()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = TreeNode<string>.Create("right");
            ITreeNode<string> returnedNode = rootNode.SetRight(ref rightNode);
            Assert.IsNotNull(returnedNode.Right);
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNonNullParameter_RightChildsReferenceIsSameAsParameters()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetRight(ref rightNode);
            Assert.IsTrue(object.ReferenceEquals(returnedNode.Right, rightNode));
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNonNullParameter_LeftChildsValueIsSameAsParameters()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> leftNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetLeft(ref leftNode);
            Assert.AreEqual(returnedNode.Left.Value, leftNode.Value);
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNonNullParameter_RightChildsValueIsSameAsParameters()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = TreeNode<string>.Create("right");
            ITreeNode<string> returnedNode = rootNode.SetRight(ref rightNode);
            Assert.AreEqual(returnedNode.Right.Value, rightNode.Value);
        }

        [TestMethod]
        public void whenSetLeftIsCalled_WithNonNullParameter_RightChildRemainsTheSame()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = rootNode.Right;
            ITreeNode<string> leftNode = TreeNode<string>.Create("left");
            ITreeNode<string> returnedNode = rootNode.SetLeft(ref leftNode);
            Assert.IsTrue(object.ReferenceEquals(returnedNode.Right, rightNode));
        }

        [TestMethod]
        public void whenSetRightIsCalled_WithNonNullParameter_LeftChildRemainsTheSame()
        {
            ITreeNode<string> rootNode = TreeNode<string>.Create("root");
            ITreeNode<string> rightNode = TreeNode<string>.Create("right");
            ITreeNode<string> leftNode = rootNode.Left;
            ITreeNode<string> returnedNode = rootNode.SetRight(ref rightNode);
            Assert.IsTrue(object.ReferenceEquals(returnedNode.Left, leftNode));
        }

    }
}
