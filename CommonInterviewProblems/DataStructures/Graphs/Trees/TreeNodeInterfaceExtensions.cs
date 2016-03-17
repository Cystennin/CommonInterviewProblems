using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees.TreeNodeInterfaceExtensions;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public static class TreeNodeInterfaceExtensions
    {
        public static ITreeNode<T> SetLeft<T>(this ITreeNode<T> root, ITreeNode<T> child)
        {
            root.Left = child;
            return root;
        }

        public static ITreeNode<T> SetRight<T>(this ITreeNode<T> root, ITreeNode<T> child)
        {
            root.Right = child;
            return root;
        }

        public static List<T> Traverse<T>(this ITreeNode<T> root)
        {
            if (null == root)
            {
                throw new ArgumentNullException(nameof(root), "cannot be called on a null reference.");
            }
            List<T> treeNodeList = new List<T>();
            treeNodeList = traverse(root, ref treeNodeList);
            return treeNodeList;
        }

        private static List<T> traverse<T>(ITreeNode<T> root, ref List<T> returnList)
        {
            if (root.Left != null)
            {
                List<T> leftList = traverse(root.Left, ref returnList);
            }
            returnList.Add(root.Value);
            if (root.Right != null)
            {
                List<T> rightList = traverse(root.Right, ref returnList);
            }
            return returnList;
        }

    }
}
