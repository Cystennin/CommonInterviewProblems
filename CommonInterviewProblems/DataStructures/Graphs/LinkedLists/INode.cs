using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public interface INode<T>
    {
        T Value { get; set; }
        INode<T> Child { get; set; }
        INode<T> Parent { get; set; }
        string ToString();
    }
}
