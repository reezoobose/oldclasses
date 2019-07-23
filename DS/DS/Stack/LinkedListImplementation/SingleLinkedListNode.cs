namespace DS.Stack.LinkedListImplementation
{
    public class SingleLinkedListNode<T>
    {
        public readonly T Info;
        public SingleLinkedListNode<T> Link;

        public SingleLinkedListNode(T value)
        {
            Info = value;
            Link = null;
        }

        public override string ToString()
        {
            return Info.ToString();
        }
    }
}