using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.Trees
{
    public interface ITreeNode<T>
    {
        T Value { get; set; }

        ITreeNode<T> Left { get; set; }
        ITreeNode<T> Right { get; set; }
    }
}
