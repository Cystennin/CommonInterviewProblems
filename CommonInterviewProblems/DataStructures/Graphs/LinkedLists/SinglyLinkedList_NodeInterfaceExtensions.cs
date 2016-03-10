using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public static class SinglyLinkedList_NodeInterfaceExtensions
    {
        public static INode<T> ToSinglyLinkedList<T>(this T[] arrayToBuildFrom)
        {
            INode<T> lastNode = null;
            INode<T> rootNode = null;
            foreach (T value in arrayToBuildFrom)
            {
                if (null == value)
                {
                    throw new ArgumentNullException(nameof(arrayToBuildFrom),
                        $"SinglyLinkedList nodes cannot be created from value arrays containing null values.");
                }
                INode<T> newNode = Node<T>.CreateNode(value);
                if (rootNode == null)
                {
                    rootNode = newNode;
                }
                if (lastNode != null)
                {
                    lastNode.Child = newNode;
                }
                lastNode = newNode;
            }
            return rootNode;
        }

        public static INode<T> InsertChild<T>(this INode<T> parent, ref INode<T> newChild)
        {
            newChild.Child = parent?.Child;
            parent.Child = newChild;
            return newChild;
        }

        public static INode<T> InsertChildren<T>(this INode<T> parent, ref INode<T> newChildren)
        {
            INode<T> lastChildOfNewChildren = newChildren.GetLastChild();
            lastChildOfNewChildren.Child = parent?.Child;
            parent.Child = newChildren;
            return newChildren;
        }

        public static INode<T> RemoveChild<T>(this INode<T> parent)
        {
            INode<T> childNode = parent?.Child as INode<T>;
            parent.Child = childNode?.Child;
            return childNode;
        }
    }
}
