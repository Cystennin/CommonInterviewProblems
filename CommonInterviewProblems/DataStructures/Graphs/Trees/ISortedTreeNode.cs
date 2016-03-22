using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public interface ISortedTreeNode<T> : ITreeNode<T> where T : IComparable<T>
    {
        ISortedTreeNode<T> Insert(ISortedTreeNode<T> node);
    }
}
