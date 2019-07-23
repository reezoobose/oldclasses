using System;
using DS.Queue.SingleLinkedListImplementation;

namespace DS.Queue.LinkedListImplementation
{
    public class DoubleEndedLinkedList<T>
    {
        #region Private Fields.

        private LinkedListNode<T> _front;
        private LinkedListNode<T> _rear;

        #endregion

        public DoubleEndedLinkedList()
        {
            _front = null;
            _rear = null;
        }

        #region Insertion

        /// <summary>
        ///     Insertion in an empty list .
        /// </summary>
        /// <param name="node"></param>
        public void InsertionInAnEmptyList(LinkedListNode<T> node)
        {
            _front = node;
            _rear = _front;
        }

        /// <summary>
        ///     Insertion at the end of the list at rear point.
        /// </summary>
        /// <param name="node"></param>
        public void InsertionAtTheEndOfTheList(LinkedListNode<T> node)
        {
            _rear.Link = node;
            _rear = node;
        }

        #endregion

        #region Deletion

        /// <summary>
        ///     Delete the only node of the list .
        /// </summary>
        /// <returns></returns>
        public T DeleteTheOnlyNode()
        {
            var info = _front.Info;
            _front = _rear = null;
            return info;
        }

        /// <summary>
        ///     Delete node from the front end.
        /// </summary>
        /// <returns></returns>
        public T Delete()
        {
            var info = _front.Info;
            _front = _front.Link;
            return info;
        }

        #endregion

        #region Helper Function

        /// <summary>
        ///     Check empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return _front == null;
        }

        /// <summary>
        ///     Check Size.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            var pointer = _front;
            var count = 0;
            while (pointer != null)
            {
                count++;
                pointer = pointer.Link;
            }

            return count;
        }

        /// <summary>
        ///     Display the.
        /// </summary>
        public void Display()
        {
            var pointer = _front;
            if (IsEmpty()) { Console.WriteLine("Empty.");}
            while (pointer != null)
            {
                Console.Write("\t"+ pointer.Info);
                pointer = pointer.Link;
            }
        }

        /// <summary>
        /// Peek.
        /// </summary>
        public void Peek()
        {
            if (!IsEmpty()) { Console.WriteLine("Peek. : "+_front.Info); }
        }

        #endregion
    }
}