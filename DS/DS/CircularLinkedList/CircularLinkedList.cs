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
        public void InsertionInAnEmptyList(CircularLinkedListNode<T> node)
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

        #endregion
    }
}