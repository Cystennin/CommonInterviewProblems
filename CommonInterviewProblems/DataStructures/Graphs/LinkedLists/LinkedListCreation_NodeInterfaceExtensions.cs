using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    internal static class LinkedListCreation_NodeInterfaceExtensions
    {
        internal static INode<T> ToLinkedList<T>(this T[] arrayToBuildFrom, bool linkParentNodes)
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
                if (linkParentNodes)
                {
                    newNode.Parent = lastNode;
                }
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
    }
}
