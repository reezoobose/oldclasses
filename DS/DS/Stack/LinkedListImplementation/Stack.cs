using System;

namespace DS.Stack.LinkedListImplementation
{
    /// <summary>
    ///     Linked List Implementation of Stack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        /// <summary>
        ///     Linked list implementation of Stack.
        /// </summary>
        private static SingleLinkedList<T> _linkedList;

        /// <summary>
        ///     Constructor.
        /// </summary>
        public Stack()
        {
            _linkedList = new SingleLinkedList<T>();
        }

        #region Insertion And Deletion

        /// <summary>
        ///     Push in the stack.
        /// </summary>
        /// <param name="info"></param>
        public void PushInStack(T info)
        {
                _linkedList.InsertAtTheBeginning(new SingleLinkedListNode<T>(info));
        }

        /// <summary>
        ///     Pop From the stack.
        /// </summary>
        /// <returns></returns>
        public T PopFromStack()
        {
            try
            {
                return  _linkedList.DeleteTheFirstNode();
            }
            catch(Exception exception)
            {
                Console.WriteLine("\nStack UnderFlow Exception Raised" +exception);
                throw new InvalidOperationException("\nOperation Not performed");
            }
        }

        /// <summary>
        ///     Peek of Stack.
        /// </summary>
        /// <returns></returns>
        public T PeekOfStack()
        {

            try
            {
                return _linkedList.FindPeek();
            }
            catch (Exception exception)
            {
                Console.WriteLine("\nStack UnderFlow "+exception);
                throw new InvalidOperationException("\nOperation Not performed");

            }
        }

        /// <summary>
        ///     Display
        /// </summary>
        public void Display()
        {
            try
            {
                _linkedList.DisplayList();
            }
            catch (Exception exception)
            {
                Console.WriteLine("\nEmpty Stack"+exception);
                throw new InvalidOperationException("\nOperation Not performed");
            }
        }

        #endregion
    }
}