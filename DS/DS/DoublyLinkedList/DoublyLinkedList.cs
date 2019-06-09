namespace DS.DoublyLinkedList
{
    /// <summary>
    ///     Doubly linked list .
    /// </summary>
    public class DoublyLinkedList<T>
    {
        /// <summary>
        ///     Start Node of the doubly Linked list .
        /// </summary>
        public DoublyLinkedListNode<T> StartNode;

        /// <summary>
        ///     Doubly Linked List.
        /// </summary>
        public DoublyLinkedList()
        {
            StartNode = null;
        }

        #region Insertion

        /// <summary>
        ///     Insert Node in a empty list .
        /// </summary>
        /// <param name="node"></param>
        public void InsertInaEmptyList(DoublyLinkedListNode<T> node)
        {
            //Point to start node .
            StartNode = node;
        }

        /// <summary>
        ///     Insert Beginning of a list .
        /// </summary>
        /// <param name="node"></param>
        public void InsertBeginningOfaList(DoublyLinkedListNode<T> node)
        {
            //connect node with the first node.
            node.Next = StartNode;
            StartNode.Previous = node;
            //Point start node.
            StartNode = node;
        }

        /// <summary>
        ///     Insert at the end of a list.
        /// </summary>
        /// <param name="node"></param>
        public void InsertEndOfaList(DoublyLinkedListNode<T> node)
        {
            if (StartNode == null)
            {
                InsertInaEmptyList(node);
                return;
            }

            var endNode = GetLastNodeOfAList();
            if (endNode == null) return;
            endNode.Next = node;
            node.Previous = endNode;
        }

        /// <summary>
        ///     Insertion before a node with value .
        /// </summary>
        /// <param name="withInfo"></param>
        /// <param name="withValue"></param>
        public void InsertionBeforeANode(T withInfo, T withValue)
        {
            var result = SearchedNode(withInfo);
            if (result == null) return;

            if (result == StartNode) InsertBeginningOfaList(new DoublyLinkedListNode<T>(withValue));

            var temp = new DoublyLinkedListNode<T>(withValue) {Previous = result.Previous, Next = result};
            result.Previous.Next = temp;
            result.Previous = temp;
        }

        /// <summary>
        ///     Insertion after a node with value.
        /// </summary>
        /// <param name="withInfo"></param>
        /// <param name="withValue"></param>
        public void InsertAfterANode(T withInfo, T withValue)
        {
            var result = SearchedNode(withInfo);
            if (result == null) return;

            //if null it indicates match found at the last node .
            if (result.Next == null)
            {
                InsertEndOfaList(new DoublyLinkedListNode<T>(withValue));
            }
            //Else match found but not is last branch.
            else
            {
                var temp = new DoublyLinkedListNode<T>(withValue) {Previous = result, Next = result.Next};
                result.Next.Previous = temp;
                result.Next = temp;
            }
        }

        #endregion

        #region Deletion

        /// <summary>
        /// Delete last node .
        /// </summary>
        public void DeleteLastNode()
        {
            var lastNode = GetLastNodeOfAList();
            if (lastNode == null) return;
            //Get the previous node .
            var predecessorNodeOfLastNode = lastNode.Previous;
            //if previous node is null it has only one node.
            if (predecessorNodeOfLastNode == null)
            {
                StartNode = null;
                return;
            }

            predecessorNodeOfLastNode.Next = null;
        }

        /// <summary>
        /// Delete the first node .
        /// </summary>
        public void DeleteTheFirstNode()
        {
            //If start node next is not null.
            //More than Two node present.
            if (StartNode.Next != null)
            {
                StartNode.Next.Previous = null;
                StartNode = StartNode.Next;
            }
            else
            {
                StartNode = null;
            }

        }


        /// <summary>
        /// Delete the node.
        /// </summary>
        /// <param name="withInfo"></param>
        public void DeleteTheNode(T withInfo)
        {
            var nodeWillBeDeleted = SearchedNode(withInfo);
            if(nodeWillBeDeleted==null)return;
            if(nodeWillBeDeleted == StartNode) { DeleteTheFirstNode();return;}
            if(nodeWillBeDeleted.Next == null) { DeleteLastNode();return;}
            var previousNode = nodeWillBeDeleted.Previous;
            var nextNode = nodeWillBeDeleted.Next;
            previousNode.Next = nextNode;
            nextNode.Previous = previousNode;
        }

        #endregion

        #region  Helper functions.

        /// <summary>
        ///     Get Last Node.
        /// </summary>
        /// <returns></returns>
        private DoublyLinkedListNode<T> GetLastNodeOfAList()
        {
            if (StartNode == null) return null;
            var pointer = StartNode;
            while (pointer.Next != null) pointer = pointer.Next;

            return pointer;
        }

        /// <summary>
        ///     Search node with info.
        /// </summary>
        /// <param name="withInfo"></param>
        /// <returns></returns>
        private DoublyLinkedListNode<T> SearchedNode(T withInfo)
        {
            if (StartNode == null) return null;
            if (StartNode.Info.Equals(withInfo)) return StartNode;

            var pointer = StartNode;
            while (pointer != null)
            {
                if (pointer.Info.Equals(withInfo)) return pointer;

                pointer = pointer.Next;
            }

            return null;
        }
    }

    #endregion
}