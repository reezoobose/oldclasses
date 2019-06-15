using System;
using System.Security.Cryptography.X509Certificates;

namespace DS.CircularLinkedList
{
    /// <summary>
    /// Circular linked list utilities.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class CircularLinkedListUtilities<T>
    {

        /// <summary>
        /// Print the circular linked list .
        /// </summary>
        /// <param name="circularLinkedList"></param>
        public static void DisplayCircularLinkedList(CircularLinkedList<T> circularLinkedList)
        {
            //if last is null.
           if(circularLinkedList.Last == null) { return;}
           //start point.
           var startPoint = circularLinkedList.Last.Link;
           do
           {

               Console.WriteLine(startPoint.Info);
               startPoint = startPoint.Link;
           } while (!startPoint.Equals(circularLinkedList.Last.Link));
        }
    }
}