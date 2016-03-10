using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public static class DoublyLinkedList_NodeInterfaceExtensions
    {
        public static INode<T> ToDoublyLinkedList<T>(this T[] sourceArray)
        {
            return sourceArray.ToLinkedList(true);
        }
    }
}
