namespace DS.SingleLinkedList
{
    /// <summary>
    ///     Dynamic Single link list .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        /// <summary>
        ///     Single linked list .
        /// </summary>
        public SingleLinkListNode<T> StartNode;

        /// <summary>
        ///     Single linked list Constructor .
        /// </summary>
        public SingleLinkedList()
        {
            //Set up start node to null .
            StartNode = null;
        }

        #region Insertion

        /// <summary>
        ///     Insert a node in an empty list .
        /// </summary>
        /// <param name="data"></param>
        public void InsertionInAnEmptyList(T data)
        {
            //create a new node .
            var node = new SingleLinkListNode<T>(data) {Link = null};
            //it should be pointed by start node .
            StartNode = node;
        }

        /// <summary>
        ///     Insert a node at the beginning .
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void InsertionAtTheBeginning(T data)
        {
            //Check start.
            if (StartNode == null)
            {
                InsertionInAnEmptyList(data);
            }
            else
            {
                //create node .
                //link new node with the first node of the list .
                //first node is pointed by the start .
                var node = new SingleLinkListNode<T>(data) {Link = StartNode};
                //Now start node should point to the new node .
                StartNode = node;
            }
        }

        /// <summary>
        ///     Insertion at the End of the list .
        /// </summary>
        /// <param name="data"></param>
        public void InsertionAtTheEndOfTheList(T data)
        {
            //Check start node .
            if (StartNode == null)
            {
                InsertionInAnEmptyList(data);
            }
            else
            {
                //Get the last node reference .
                var lastNode = GetReferenceToTheLastNode();
                //If last node is not null.
                if (lastNode != null) lastNode.Link = new SingleLinkListNode<T>(data) {Link = null};
            }
        }

        /// <summary>
        ///     Insertion after a node.
        /// </summary>
        /// <param name="searchNodeValue">Node containing value.</param>
        /// <param name="newNodeValue">New node value.</param>
        public void InsertionAfterANode(T searchNodeValue, T newNodeValue)
        {
            //start node check
            if (StartNode == null) return;

            //Get the reference of the node contain value.
            var referenceNode = GetNode(searchNodeValue);
            //if the node with data found .
            if (referenceNode == null) return;

            //create the node .
            //Connect new node with the next node of the reference node.
            var newNode = new SingleLinkListNode<T>(newNodeValue) {Link = referenceNode.Link};
            //reset the link between reference node and new node .
            referenceNode.Link = newNode;
        }

        /// <summary>
        ///     Insertion before a node.
        /// </summary>
        /// <param name="searchNodeValue">Node containing value.</param>
        /// <param name="newNodeValue">New node value.</param>
        public void InsertionBeforeANode(T searchNodeValue, T newNodeValue)
        {
            //start node check
            if (StartNode == null) return;

            //Get the reference of the predecessor node that contain value.
            var referenceNode = GetPredecessorNode(searchNodeValue);
            //if the node with data found .
            if (referenceNode == null) return;

            //Reference node is not a start node .
            if (referenceNode != StartNode)
            {
                //create the node .
                //Connect new node with the next node of the reference node.
                var newNode = new SingleLinkListNode<T>(newNodeValue) {Link = referenceNode.Link};
                //reset the link between reference node and new node .
                referenceNode.Link = newNode;
            }
            //A reference node can be a start node in both condition .
            //Either searched value present in start node or.
            //second node contain the searched value .
            else
            {
                {
                    // Reference node is a start node nad it contains the searched value.
                    if (referenceNode.Info.Equals(searchNodeValue))
                    {
                        InsertionAtTheBeginning(newNodeValue);
                    }
                    else
                    {
                        //create the node .
                        //Connect new node with the next node of the reference node.
                        var newNode = new SingleLinkListNode<T>(newNodeValue) {Link = referenceNode.Link};
                        //reset the link between reference node and new node .
                        referenceNode.Link = newNode;
                    }
                }
            }
        }

        /// <summary>
        ///     Insert a new node at position .
        /// </summary>
        /// <param name="position">Position in the list.</param>
        /// <param name="withInfo">Info part of the node.</param>
        public void InsertANewNodeAtPosition(int position, T withInfo)
        {
            //Get the reference of the predecessor node of the position .
            var referenceNode = GetPredecessorNodeAtPosition(position);
            //if the node with data found .
            if (referenceNode == null) return;
            //When reference node is not the start node .
            if (referenceNode != StartNode)
            {
                //create the node .
                //Connect new node with the next node of the reference node.
                var newNode = new SingleLinkListNode<T>(withInfo) {Link = referenceNode.Link};
                //reset the link between reference node and new node .
                referenceNode.Link = newNode;
            }
            else
            {
                //Insert node at the beginning of the node .
                InsertionAtTheBeginning(withInfo);
            }
        }

        #endregion

        #region Deletion

        /// <summary>
        ///     Delete first node .
        /// </summary>
        public void DeleteFirstNode()
        {
            //Check start node.
            if (StartNode == null) return;
            //2nd node .
            var secondNode = StartNode.Link;
            //let start node point it .
            StartNode = secondNode;
        }

        /// <summary>
        ///     Delete the last node .
        /// </summary>
        public void DeleteLastNode()
        {
            if (StartNode == null) return;

            //Go to the one node before the last node .
            var predecessorNodeOfLastNode = GetReferenceToThePredecessorOfLastNode();
            //Only one node exist .
            if (StartNode.Link == null)
            {
                //Remove that node .
                StartNode = null;
                return;
            }

            //Find predecessor of last node.
            if (predecessorNodeOfLastNode == null) return;
            //Remove last node .
            predecessorNodeOfLastNode.Link = null;
        }

        /// <summary>
        ///     Delete node with value .
        /// </summary>
        /// <param name="searchNodeValue"></param>
        public void DeleteNodeWithValue(T searchNodeValue)
        {
            //Check node .
            var desiredNode = GetNode(searchNodeValue);
            //null check.
            if (desiredNode == null) return;
            //check start node.
            if (desiredNode == StartNode) StartNode = StartNode.Link;

            //Get predecessor of last node .
            desiredNode = GetPredecessorNode(searchNodeValue);
            //null check.
            if (desiredNode == null) return;
            //Remove that node .
            desiredNode.Link = desiredNode.Link.Link;
        }

        #endregion

        #region Helper Functions

        /// <summary>
        ///     Return a reference to the last node .
        ///     Minimum one node should be present .
        /// </summary>
        /// <returns></returns>
        private SingleLinkListNode<T> GetReferenceToTheLastNode()
        {
            //Set up start node .
            var pointer = StartNode;
            //If no node then return null
            if (StartNode == null) return null;
            //Iterate over list .
            while (pointer.Link != null)
                //Move next.
                pointer = pointer.Link;
            //return pointer .
            return pointer;
        }

        /// <summary>
        ///     Return a reference to the predecessor of the last node .
        ///     At least two node should be present .
        /// </summary>
        /// <returns></returns>
        private SingleLinkListNode<T> GetReferenceToThePredecessorOfLastNode()
        {
            //Set up start node .
            var pointer = StartNode;
            //If no node then return null
            //check more than one node present .
            if (StartNode?.Link == null) return null;

            //Second last finding.
            while (pointer.Link.Link != null)
                //move next.
                pointer = pointer.Link;

            //return pointer.
            return pointer;
        }

        /// <summary>
        ///     Return a reference to the node with particular info
        /// </summary>
        /// <returns></returns>
        private SingleLinkListNode<T> GetNode(T withInfo)
        {
            //Set up start node.
            var pointer = StartNode;
            //Start node is null .
            if (StartNode == null) return null;
            //Iterate .
            while (pointer != null)
            {
                //Check .
                if (pointer.Info.Equals(withInfo)) return pointer;

                //Move next 
                pointer = pointer.Link;
            }

            return null;
        }

        /// <summary>
        ///     Return a reference to the Predecessor node with particular info
        ///     Predecessor node = one node behind the required node .
        ///     At least two node required .
        /// </summary>
        /// <returns></returns>
        private SingleLinkListNode<T> GetPredecessorNode(T withInfo)
        {
            //Set up start node.
            var pointer = StartNode;
            //Start node is null .
            if (StartNode == null) return null;

            //Checking Start node separately .
            if (pointer.Info.Equals(withInfo)) return pointer;

            //Iterating Over Next Node Of Pointer .
            while (pointer.Link != null)
            {
                //Check .
                if (pointer.Link.Info.Equals(withInfo)) return pointer;

                //Move next 
                pointer = pointer.Link;
            }

            //Nothing left .
            return null;
        }

        /// <summary>
        ///     Get node at particular position .
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private SingleLinkListNode<T> GetNodeAtPosition(int position)
        {
            //Assign pointer to start node .
            var pointer = StartNode;
            //No list not node.
            if (StartNode == null) return null;
            //negative index not allowed .
            if (position <= 0) return null;
            //node count.
            var count = 1;
            //condition.
            var positionCondition = count < position;
            var notNullCondition = pointer.Link != null;
            var check = positionCondition && notNullCondition;
            //iterate.
            while (check)
            {
                //move next .
                pointer = pointer.Link;
                count++;
            }

            return pointer.Link == null ? null : pointer;
        }

        /// <summary>
        ///     Get predecessor node at particular position .
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private SingleLinkListNode<T> GetPredecessorNodeAtPosition(int position)
        {
            //Assign pointer to start node .
            var pointer = StartNode;
            //No list not node.
            if (StartNode == null) return null;
            //negative index not allowed .
            if (position <= 0) return null;
            //node count.
            var count = 1;
            //iterate.
            while (count < position - 1 && pointer.Link != null)
            {
                //move next .
                pointer = pointer.Link;
                count++;
            }

            return pointer.Link == null ? null : pointer;
        }

        #endregion
    }
}