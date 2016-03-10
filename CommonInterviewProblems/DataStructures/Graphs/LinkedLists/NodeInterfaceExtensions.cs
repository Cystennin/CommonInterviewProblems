using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public static class NodeInterfaceExtensions
    {
        public static INode<T> GetLastChild<T>(this INode<T> node)
        {
            if (node?.Child == null)
            {
                return node;
            }
            return GetLastChild(node.Child);
        }

        public static int Length<T>(this INode<T> node)
        {
            return findLength(node, 1);
        }

        private static int findLength<T>(INode<T> node, int length)
        {
            if (node?.Child == null)
            {
                return length;
            }
            return findLength(node.Child, length + 1);
        }

        public static string ToString<T>(this INode<T> node)
        {
            return buildString(node, new StringBuilder());
        }

        private static string buildString<T>(INode<T> node, StringBuilder stringBuilder)
        {
            stringBuilder.Append($"{node.Value}->");
            if (node.Child == null)
            {
                stringBuilder.Append("NULL");
                return stringBuilder.ToString();
            }
            return buildString(node.Child, stringBuilder);
        }

        public static bool LoopDetected<T>(this INode<T> node)
        {
            return detectLoopWithPointers(node, node.Child);
        }

        private static bool detectLoopWithPointers<T>(INode<T> x, INode<T> y)
        {
            if ((null == x) || (null == y))
            {
                return false;
            }
            if (y.Equals(x))
            {
                return true;
            }
            if (y.Child != null && y.Child.Equals(x))
            {
                return true;
            }
            return detectLoopWithPointers(x?.Child, y?.Child?.Child);
        }

        private static bool detectLoopWithStack<T>(INode<T> node, Stack<INode<T>> pathStack)
        {
            if (node.Child.Equals(null))
            {
                return false;
            }
            else if (!pathStack.Contains(node))
            {
                pathStack.Push(node);
                detectLoopWithStack(node.Child, pathStack);
            }
            return true;
        }

    }
}
