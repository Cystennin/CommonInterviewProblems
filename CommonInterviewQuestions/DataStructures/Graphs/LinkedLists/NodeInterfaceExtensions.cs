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

    }
}
