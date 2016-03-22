using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public class TreeNode<T> : ITreeNode<T>
    {
        public static TreeNode<T> Create(T value)
        {
            return new TreeNode<T>(value);
        }

        protected internal TreeNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public ITreeNode<T> Left { get; set; }
        public ITreeNode<T> Right { get; set; }

        public ITreeNode<T> Parent { get; set; }
    }
}
