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
            return arrayToBuildFrom.ToLinkedList(false);
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
