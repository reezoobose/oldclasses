using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace DS.CircularLinkedList
{
    /// <summary>
    ///     Circular Linked List.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T>
    {
        //Last reference.
        public CircularLinkedListNode<T> Last;

        //Constructor.
        public CircularLinkedList()
        {
            Last = null;
        }

        #region Insertion

        /// <summary>
        /// Insertion in an empty list.
        /// </summary>
        /// <param name="node"></param>
        private void InsertionInAnEmptyList(CircularLinkedListNode<T> node)
        {
            Last = node;
            Last.Link = Last;
        }

        /// <summary>
        /// Insertion Beginning  of list.
        /// </summary>
        /// <param name="node"></param>
        public void InsertBeginningOfaList(CircularLinkedListNode<T> node)
        {
            //For Empty List.
            if (Last == null)
            {
                InsertionInAnEmptyList(node);
                return;
            }

            node.Link = Last.Link;
            Last.Link = node;
        }

        /// <summary>
        /// Insertion at the end of the list.
        /// </summary>
        /// <param name="node"></param>
        public void InsertEndOfaList(CircularLinkedListNode<T> node)
        {
            //For empty list.
            if (Last == null)
            {
                InsertionInAnEmptyList(node);
                return;
            }

            node.Link = Last.Link;
            Last.Link = node;
            Last = node;
        }

        /// <summary>
        /// Insert a new node after the node .
        /// </summary>
        /// <param name="searchedNode"></param>
        /// <param name="newNode"></param>
        public void InsertAfterANode(T searchedNode, T newNode)
        {
            var result = GetNode(searchedNode);
            if (result == null) return;
            if (result.Equals(Last)){ InsertEndOfaList(new CircularLinkedListNode<T>(newNode)); return;}
            var temp = new CircularLinkedListNode<T>(newNode) {Link = result.Link};
            result.Link = temp;
        }

        /// <summary>
        /// Insertion a node before the node .
        /// </summary>
        /// <param name="searchedNode"></param>
        /// <param name="newNode"></param>
        public void InsertionBeforeANode(T searchedNode, T newNode)
        {
            var result = GetPredecessorNode(searchedNode);
            if (result == null) return;
            if (result.Equals(Last)) { InsertEndOfaList(new CircularLinkedListNode<T>(newNode)); return; }
            var temp = new CircularLinkedListNode<T>(newNode) { Link = result.Link };
            result.Link = temp;


        }

        #endregion

        #region Deletion

        /// <summary>
        /// Delete only node .
        /// </summary>
        private void DeleteOnlyNode()
        {
            Last = null;
        }

        /// <summary>
        /// Delete first node.
        /// </summary>
        public void DeleteFirstNode()
        {
            //Empty list check.
            if(Last == null) return;
            //if list contains only one node .
            if (Last.Link.Equals(Last)) {DeleteOnlyNode();return;}
            //general case.
            Last.Link = Last.Link.Link;
        }

        /// <summary>
        /// Delete The last Node.
        /// </summary>
        public void DeleteLastNode()
        {
            //Empty list check.
            if (Last == null) return;
            //if list contains only one node .
            if (Last.Link.Equals(Last)) { DeleteOnlyNode(); return; }
            //get the predecessor node.
            var pointer = Last.Link;
            //Iterate to the predecessor.
            while (!pointer.Link.Equals(Last))
            {
                pointer = pointer.Link;
            }
            pointer.Link = Last.Link;
            Last = pointer;
        }

        /// <summary>
        /// Delete Node that contain value.
        /// </summary>
        /// <param name="containValue"></param>
        public void DeleteNode(T containValue)
        {
            //Search the node.
            var result = GetNode(containValue);
            //If result null.
            if(result == null) return;
            //if result is the first node .
            if (result == Last.Link)
            {
                DeleteFirstNode();
                return;
            }
            //if last node.
            if (result.Equals(Last))
            {
                DeleteLastNode();
                return;
            }
            //general case.
            var predecessor = GetPredecessorNode(containValue);
            //delete.
            predecessor.Link = predecessor.Link.Link;
        }

        #endregion

        #region Helper Functions


        /// <summary>
        /// Returns the searched node.
        /// </summary>
        /// <param name="withInfo"></param>
        /// <returns></returns>
        private CircularLinkedListNode<T> GetNode(T withInfo)
        {
            var pointer = Last.Link;
            do
            {
                if (pointer.Info.Equals(withInfo)) return pointer;

                pointer = pointer.Link;
            } while (!pointer.Equals(Last.Link));

            return null;
        }

        /// <summary>
        /// Get Predecessor Node of the searched node .
        /// </summary>
        /// <param name="withInfo"></param>
        /// <returns></returns>
        private CircularLinkedListNode<T> GetPredecessorNode(T withInfo)
        {
            var pointer = Last.Link;
            do
            {
                if (pointer.Link.Info.Equals(withInfo)) return pointer;

                pointer = pointer.Link;
            } while (!pointer.Equals(Last.Link));

            return null;
        }


        #endregion
    }
}