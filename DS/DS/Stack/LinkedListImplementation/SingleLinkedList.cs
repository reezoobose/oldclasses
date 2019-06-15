using System;

namespace DS.Stack.LinkedListImplementation
{
    /// <summary>
    ///     Single linked list .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        private SingleLinkedListNode<T> _start;

        /// <summary>
        ///     Constructor
        /// </summary>
        public SingleLinkedList()
        {
            _start = null;
        }

        #region Insertion

        /// <summary>
        ///     Insertion in an empty list.
        /// </summary>
        /// <param name="newNode"></param>
        private void InsertInAnEmptyList(SingleLinkedListNode<T> newNode)
        {
            _start = newNode;
        }

        /// <summary>
        ///     Insert At the beginning of the node.
        /// </summary>
        public void InsertAtTheBeginning(SingleLinkedListNode<T> newNode)
        {
            if (_start == null)
            {
                InsertInAnEmptyList(newNode);
                return;
            }

            newNode.Link = _start;
            _start = newNode;
        }

        #endregion

        #region Deletion

        /// <summary>
        ///     Delete the only node of the list .
        /// </summary>
        private void DeleteTheOnlyNodeOfTheList()
        {
            _start = null;
        }

        /// <summary>
        ///     Delete the First node .
        /// </summary>
        /// <returns></returns>
        public T DeleteTheFirstNode()
        {
            //For empty list .
            if (_start == null) throw new OperationCanceledException("\nList is Empty.\n");

            //Get the info.
            var info = _start.Info;
            //For list with one node .
            if (_start.Link == null)
            {
                DeleteTheOnlyNodeOfTheList();
                return info;
            }


            //Start points to the second node .
            _start = _start.Link;
            return info;
        }

        #endregion

        #region Helpers Function

        /// <summary>
        ///     Display list .
        /// </summary>
        public void DisplayList()
        {
            if (_start == null) throw new OperationCanceledException("\nList is Empty.\n");
            var pointer = _start;

            while (pointer != null)
            {
                Console.Write("\t" + pointer.Info);
                pointer = pointer.Link;
            }
        }

        /// <summary>
        ///     Find the peek.
        /// </summary>
        public T FindPeek()
        {
            if (_start == null) throw new OperationCanceledException("\nList is Empty.\n");

            return _start.Info;
        }

        #endregion
    }
}