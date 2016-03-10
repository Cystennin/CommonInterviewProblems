using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public class SinglyLinkedList<T> : Node<T>, INode<T>, ISinglyLinkedListNode<T>
    {
        public static ISinglyLinkedListNode<T> Create(ref INode<T> rootNode)
        {
            SinglyLinkedList<T> newSinglyLinkedList = new SinglyLinkedList<T>(ref rootNode);
            return newSinglyLinkedList;
        }

        private SinglyLinkedList(ref INode<T> rootNode) : base()
        {
            this.Child = rootNode.Child;
            this.Value = rootNode.Value;
        }

        public ISinglyLinkedListNode<T> InsertChild(ref ISinglyLinkedListNode<T> newChild)
        {
            newChild.Child = this?.Child;
            this.Child = newChild;
            return newChild;
        }

        public ISinglyLinkedListNode<T> InsertChildren(ref ISinglyLinkedListNode<T> newChildren)
        {
            ISinglyLinkedListNode<T> lastChildOfNewChildren = this.GetLastChild() as ISinglyLinkedListNode<T>;
            lastChildOfNewChildren.Child = this?.Child;
            this.Child = newChildren;
            return newChildren;
        }

        public ISinglyLinkedListNode<T> RemoveChild()
        {
            ISinglyLinkedListNode<T> childNode = this?.Child as ISinglyLinkedListNode<T>;
            this.Child = childNode?.Child;
            return childNode;
        }

        public ISinglyLinkedListNode<T> RemoveChildren()
        {
            ISinglyLinkedListNode<T> childNode = this?.Child as ISinglyLinkedListNode<T>;
            this.Child = null ;
            return childNode;
        }

        public ISinglyLinkedListNode<T> LastChild
        {
            get
            {
                return this.GetLastChild() as ISinglyLinkedListNode<T>;
            }
        }
    }
}
