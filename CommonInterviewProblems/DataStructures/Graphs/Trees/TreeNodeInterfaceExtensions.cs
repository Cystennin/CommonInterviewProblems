using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public static class TreeNodeInterfaceExtensions
    {
        public static ITreeNode<T> SetLeft<T>(this ITreeNode<T> root, ref ITreeNode<T> child)
        {
            root.Left = child;
            return root;
        }

        public static ITreeNode<T> SetRight<T>(this ITreeNode<T> root, ref ITreeNode<T> child)
        {
            root.Right = child;
            return root;
        }

        public static List<T> Traverse<T>(this ITreeNode<T> root)
        {
            List<T> treeNodeList = new List<T>();

            return treeNodeList;
        }

    }
}
