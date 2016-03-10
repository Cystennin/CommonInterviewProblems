using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{

    public class Node<T> : INode<T>
    {
        private static readonly log4net.ILog logger = LogHelper.GetLoggerForThisClass();

        public static Node<T> CreateNode(T initialValue)
        {
            return new Node<T>(initialValue);
        }

        protected Node()
        {
        }

        protected Node(T initialValue)
        {
            Value = initialValue;
        }

        public T Value { get; set; }
        public INode<T> Child { get; set; }
        public INode<T> Parent { get; set; }

        public override string ToString()
        {
            return this.ToString<T>();
        }
    }
}
