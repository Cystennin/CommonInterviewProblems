using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public class SortedTreeNode<T> : TreeNode<T>, ISortedTreeNode<T> where T : IComparable<T>
    {
        protected internal SortedTreeNode(T value) : base(value) { }

        public ISortedTreeNode<T> Insert(ISortedTreeNode<T> node)
        {
            if (null == node)
            {
                throw new ArgumentNullException(nameof(node),"Cannot insert a null node into tree!");
            }

            return insert(this, node);
        }

        private ISortedTreeNode<T> insert(ISortedTreeNode<T> root, ISortedTreeNode<T> node)
        {
            if (root is ISortedTreeNode<T>)
            {
                int comparison = this.Value.CompareTo(node.Value);
                switch (comparison)
                {
                    case -1:
                        if (root.Left == null)
                        {
                            node.Parent = root;
                            root.Left = node;
                        }
                        else
                        {
                            return this.insert(root.Left as ISortedTreeNode<T>, node);
                        }
                        break;
                    case 0:
                        throw new InvalidOperationException($"value of {nameof(node)}({node.Value}) already exists in the tree!");
                    case 1:
                        if (root.Right == null)
                        {
                            node.Parent = root;
                            root.Right = node;
                        }
                        else
                        {
                            return this.insert(root.Right as ISortedTreeNode<T>, node);
                        }
                        break;
                }
            }
            else
            {
                throw new InvalidOperationException("Attempting to insert at a position that isn't sortable!");
            }

            return this;
        }
        
    }
}
