using System;

namespace DS.DoublyLinkedList
{
    /// <summary>
    /// Double Linked List Utilities .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class DoublyLinkedListUtilities<T>
    {
        /// <summary>
        /// Print the double linked list .
        /// </summary>
        /// <param name="startNode"></param>
        public static void PrintList(DoublyLinkedListNode<T> startNode)
        {
            Console.WriteLine("\n\n[LinkedListUtilities]Printing List. ");
            if (startNode == null)
            {
                //Debug.
                Console.WriteLine("\t[LinkedListUtilities] :Empty List.");
            }
            else
            {
                //Set up an pointer .
                var pointer = startNode;
                //Pointer not null.
                while (pointer != null)
                {
                    //Debug.
                    Console.WriteLine("{0}", pointer.Info);
                    //Move forward.
                    pointer = pointer.Next;
                }
            }
        }
    }
}
