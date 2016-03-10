using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists
{
    public interface ISinglyLinkedListNode<T> : INode<T>
    {
        /// <summary>
        /// Inserts the specified node as the child of the current node and as the parent of the current node's current child, if any.
        /// Any children of the specified node are not inserted and will be lost if a copy of the newChild node not saved.
        /// </summary>
        /// <param name="newChild">The child to insert</param>
        /// <returns>a reference to the new Child</returns>
        ISinglyLinkedListNode<T> InsertChild(ref ISinglyLinkedListNode<T> newChild);

        /// <summary>
        /// Inserts the specified node, and all of it's children, between the current node and it's current child.
        /// </summary>
        /// <param name="newChildren"></param>
        /// <returns>a reference to the new child</returns>
        ISinglyLinkedListNode<T> InsertChildren(ref ISinglyLinkedListNode<T> newChildren);

        /// <summary>
        /// Replaces the child node of the current node, if any, with that child's own child node.
        /// </summary>
        /// <returns>The child node which was removed</returns>
        ISinglyLinkedListNode<T> RemoveChild();

        /// <summary>
        /// Removes the child, and all of it's children from the current node.
        /// </summary>
        /// <returns>The child node which was removed, with all of it's children.</returns>
        ISinglyLinkedListNode<T> RemoveChildren();

        /// <summary>
        /// Returns the last child node of the current node's children.
        /// </summary>
        /// <returns>The last child node of the current node's children.</returns>
        ISinglyLinkedListNode<T> LastChild { get; }

    }
}
