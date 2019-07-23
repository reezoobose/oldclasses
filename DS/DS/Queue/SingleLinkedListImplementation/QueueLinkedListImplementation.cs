using System;
using System.Runtime.Remoting.Messaging;
using DS.Queue.LinkedListImplementation;

namespace DS.Queue.SingleLinkedListImplementation
{
    /// <summary>
    /// Queue Linked List Implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueLinkedListImplementation<T>
    {
        private static DoubleEndedLinkedList<T> _list;

        public QueueLinkedListImplementation()
        {
            _list = new DoubleEndedLinkedList<T>();
        }


        /// <summary>
        /// Enqueue
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            if (_list.IsEmpty()) { _list.InsertionInAnEmptyList(new LinkedListNode<T>(data));return;}
            _list.InsertionAtTheEndOfTheList(new LinkedListNode<T>(data));
            
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (_list.IsEmpty()) { throw new InvalidOperationException("Queue Under Flow."); }

            return _list.Delete();

        }

        /// <summary>
        /// Display.
        /// </summary>
        public void Display()
        {
            _list.Display();
        }

        /// <summary>
        /// Peek.
        /// </summary>
        public void Peek()
        {
            _list.Peek();
        }

        /// <summary>
        /// Size of the queue .
        /// </summary>
        /// <returns></returns>
        public int SizeofQueue()
        {
            return _list.IsEmpty() ? 0 : _list.Size();
        }
    }
}
