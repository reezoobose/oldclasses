namespace DS.CircularLinkedList
{
    /// <summary>
    ///     Circular Linked List Node .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedListNode<T>
    {
        //Info part.
        public T Info;

        //Node part .
        public CircularLinkedListNode<T> Link;

        //Constructor.
        public CircularLinkedListNode(T data)
        {
            Info = data;
            Link = null;
        }
    }
}