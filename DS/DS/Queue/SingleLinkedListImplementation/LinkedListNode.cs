namespace DS.Queue.SingleLinkedListImplementation
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Link;
        public readonly T Info;

        public LinkedListNode(T info)
        {
            Info = info;
            Link = null;
        }

    }
}