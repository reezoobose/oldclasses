using System;
using System.Diagnostics;

namespace DS.SingleLinkedList
{
    /// <summary>
    ///     Linked list Utilities.
    /// </summary>
    public class SingleLinkedListUtilities<T>
    {
        #region Public Region

        /// <summary>
        ///     Number of nodes present in the node .
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int GetNumberOfNodes(SingleLinkedList<T> list)
        {
            //Set up a pointer .
            var pointer = list.StartNode;
            //If null no node .
            if (pointer == null) return 0;

            var temp = 0;
            //Iterate unless null.
            while (pointer != null)
            {
                //move next
                pointer = pointer.Link;
                //increment
                temp++;
            }

            //return count.
            return temp;
        }

        /// <summary>
        ///     Print list .
        /// </summary>
        public static void PrintList(SingleLinkListNode<T> startNode)
        {
            Console.WriteLine("\n\n[LinkedListUtilities]Printing List. ");
            if (startNode == null)
            {
                //Debug.
                Console.WriteLine("\t[LinkedListUtilities :Empty List.");
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
                    pointer = pointer.Link;
                }
            }
        }

        /// <summary>
        ///     Search over the list with a value .
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="position"></param>
        /// <param name="list"></param>
        /// <returns>True if value found.</returns>
        public static bool Search(T value, out int position, SingleLinkedList<T> list)
        {
            //Set up position to 0;
            position = 1;
            //Check for the start node is not null.
            if (list.StartNode == null)
            {
                //If not found position should be set to -1 ,
                position = -1;
                //debug
                Console.WriteLine("\t[SingleLinkedList : ] Empty Linked List");
                //Return false .
                return false;
            }

            var pointer = list.StartNode;
            //Iterate unless null
            while (pointer != null)
            {
                //When found
                if (pointer.Info.Equals(value)) return true;
                //Move next .
                pointer = pointer.Link;
                //increment position.
                position++;
            }

            //Dead end .
            if (pointer == null) return false;
            //If not found position should be set to -1 ,
            position = -1;
            //Return false not found .
            return false;
        }

        /// <summary>
        ///     Sort Linked List Using Bubble Sort .
        ///     This Method will Only swap the info part .
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleSortOne(SingleLinkedList<T> list)
        {
            var stopwatch = Stopwatch.StartNew();
            if (list.StartNode == null) return;
            //Initially endPointer is pointing end of a list ie. null
            //Taking another pointer current pointing the first node .
            SingleLinkListNode<T> currentPointer;
            //First Loop Iterate (Number of nodes - 1) times.
            //When EndPointer reaches to the at the second node of the list it means loop is sorted .
            for (SingleLinkListNode<T> endPointer = null;
                endPointer != list.StartNode.Link;
                endPointer = currentPointer)
            for (currentPointer = list.StartNode;
                currentPointer.Link != endPointer;
                currentPointer = currentPointer.Link)
            {
                //Next Pointer will point the next node of current pointer.
                var nextPointer = currentPointer.Link;
                //check swap.
                if (currentPointer <= nextPointer) continue;
                //Perform swap.
                var temp = currentPointer.Info;
                currentPointer.Info = nextPointer.Info;
                nextPointer.Info = temp;
            }

            // Get the elapsed time as a TimeSpan value.
            var ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
            Console.WriteLine("\t[SingleLinkedList : ]Time Taken to complete the sorting process = {0}", elapsedTime);
        }

        /// <summary>
        ///     Sort Linked List Using Bubble Sort.
        ///     This method Will Swap The Reference.
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleSortTwo(SingleLinkedList<T> list)
        {
            //Start node .
            if(list.StartNode == null) {return;}
            var stopwatch = Stopwatch.StartNew();
            //Take a pointer to point the current node.
            SingleLinkListNode<T> currentPointer;
            //Iteration block for total pass .
            for (SingleLinkListNode<T> endPointer = null;
                endPointer != list.StartNode.Link;
                endPointer = currentPointer)
            {
                //Take a pointer to point the previous node of the current node.
                SingleLinkListNode<T> previousPointer = null; // you can initialize it to the start node also .
                for (currentPointer = list.StartNode;
                    currentPointer.Link != endPointer;
                    previousPointer = currentPointer, currentPointer = currentPointer.Link)
                {
                    //Take a pointer to point the next node to the current node.
                    var nextPointer = currentPointer.Link;
                    //check swap.
                    if (currentPointer > nextPointer)
                    {
                        currentPointer.Link = nextPointer.Link;
                        nextPointer.Link = currentPointer;
                        //When no node before current node.
                        //If you have initialize it to the start node then check for the start node .
                        if (previousPointer == null)
                            list.StartNode = nextPointer;
                        else
                            previousPointer.Link = nextPointer;

                        //Change the reference .
                        var temp = currentPointer;
                        currentPointer = nextPointer;
                        nextPointer = temp;
                    }
                }
            }

            // Get the elapsed time as a TimeSpan value.
            var ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
            Console.WriteLine("\t[SingleLinkedList : ]Time Taken to complete the sorting process = {0}", elapsedTime);
        }


        /// <summary>
        ///     Merge Two Sorted Link List .
        /// </summary>
        /// <param name="startNodeOfFirstLinkList"></param>
        /// <param name="startNodeOfSecondLinkList"></param>
        public static SingleLinkListNode<T> MergeInNewList(SingleLinkListNode<T> startNodeOfFirstLinkList,
            SingleLinkListNode<T> startNodeOfSecondLinkList)
        {
            //create a start node for the new list .
            SingleLinkListNode<T> newListStartNode = null;
            //create a end pointer for the new list .
            //it always points the end node of the new list.
            SingleLinkListNode<T> endPointer = null;
            //First List Pointer .
            var firstListPointer = startNodeOfFirstLinkList;
            //Second List Pointer .
            var secondListPointer = startNodeOfSecondLinkList;

            //Iterate unless one of the list comes to the end .
            while (firstListPointer != null && secondListPointer != null)
                //compare .
                //Node of first list is greater than node of second list.
                //The smaller one will be added in the new list .
                //We will increment the pointer of the list whose element is selected and added to the next list.
                if (firstListPointer > secondListPointer)
                {
                    //create a new node with the value .
                    var newNode = new SingleLinkListNode<T>(secondListPointer.Info);
                    //if we are adding first element .
                    if (newListStartNode == null)
                    {
                        //Set up the start node .
                        newListStartNode = newNode;
                        //set up the end pointer .
                        endPointer = newNode;
                    }
                    else
                    {
                        //Adding at the end of the end pointer .
                        endPointer.Link = newNode;
                        //increment the end pointer of the new list .
                        endPointer = endPointer.Link;
                    }

                    //Increment the pointer.
                    secondListPointer = secondListPointer.Link;
                }
                else
                {
                    //create a new node with the value .
                    var newNode = new SingleLinkListNode<T>(firstListPointer.Info);
                    //if we are adding first element .
                    if (newListStartNode == null)
                    {
                        //Set up the start node .
                        newListStartNode = newNode;
                        //set up the end pointer .
                        endPointer = newNode;
                    }
                    else
                    {
                        //Adding at the end of the end pointer .
                        endPointer.Link = newNode;
                        //increment the end pointer of the new list .
                        endPointer = endPointer.Link;
                    }

                    //Increment the pointer.
                    firstListPointer = firstListPointer.Link;
                }

            //Add all the elements  of the Unfinished first list .
            while (firstListPointer != null)
            {
                //create a new node with the value .
                var newNode = new SingleLinkListNode<T>(firstListPointer.Info);
                //Adding at the end of the end pointer .
                endPointer.Link = newNode;
                //increment the end pointer of the new list .
                endPointer = endPointer.Link;
                firstListPointer = firstListPointer.Link;
            }

            //Add all the element of the Unfinished second list.
            while (secondListPointer != null)
            {
                //create a new node with the value .
                var newNode = new SingleLinkListNode<T>(secondListPointer.Info);
                //Adding at the end of the end pointer .
                endPointer.Link = newNode;
                //increment the end pointer of the new list .
                endPointer = endPointer.Link;
                //Move ahead.
                secondListPointer = secondListPointer.Link;
            }

            return newListStartNode;
        }


        /// <summary>
        ///     Merge two sorted list by changing reference .
        /// </summary>
        /// <param name="startNodeOfFirstLinkList"></param>
        /// <param name="startNodeOfSecondLinkList"></param>
        /// <returns></returns>
        public static SingleLinkListNode<T> Merge(SingleLinkListNode<T> startNodeOfFirstLinkList,
            SingleLinkListNode<T> startNodeOfSecondLinkList)
        {
            //create a start node for the new list .
            SingleLinkListNode<T> newListStartNode = null;
            //create a end pointer for the new list .
            //it always points the end node of the new list.
            SingleLinkListNode<T> endPointer = null;
            //First List Pointer .
            var firstListPointer = startNodeOfFirstLinkList;
            //Second List Pointer .
            var secondListPointer = startNodeOfSecondLinkList;

            //Iterate unless one of the list comes to the end .
            while (firstListPointer != null && secondListPointer != null)
                //compare .
                //Node of first list is greater than node of second list.
                //The smaller one will be taken.
                //We will increment the pointer of the list whose element is selected and added to the next list.
                if (firstListPointer > secondListPointer)
                {
                    //if we are adding first element .
                    if (newListStartNode == null)
                    {
                        //Set up the start node .
                        newListStartNode = secondListPointer;
                        //set up the end pointer .
                        endPointer = secondListPointer;
                    }
                    else
                    {
                        //Adding at the end of the end pointer .
                        endPointer.Link = secondListPointer;
                        //increment the end pointer of the new list .
                        endPointer = endPointer.Link;
                    }

                    //Increment the pointer.
                    secondListPointer = secondListPointer.Link;
                }
                else
                {
                    //if we are adding first element .
                    if (newListStartNode == null)
                    {
                        //Set up the start node .
                        newListStartNode = firstListPointer;
                        //set up the end pointer .
                        endPointer = firstListPointer;
                    }
                    else
                    {
                        //Adding at the end of the end pointer .
                        endPointer.Link = firstListPointer;
                        //increment the end pointer of the new list .
                        endPointer = endPointer.Link;
                    }

                    //Increment the pointer.
                    firstListPointer = firstListPointer.Link;
                }

            //Add all the elements  of the Unfinished first list .
            if (firstListPointer != null) endPointer.Link = firstListPointer;

            //Add all the element of the Unfinished second list.
            if (secondListPointer != null) endPointer.Link = secondListPointer;

            return newListStartNode;
        }

        /// <summary>
        ///     Reverse the linked list.
        /// </summary>
        /// <param name="list">Reverse the list.</param>
        public static void ReverseLinkedList(SingleLinkedList<T> list)
        {
            //Empty list check.
            if (list.StartNode == null) return;

            //Take 3 pointer .
            //Current will point with the first node .
            var currentPointer = list.StartNode;
            //Previous pointer at the beginning points nothing .
            SingleLinkListNode<T> previousPointer = null;
            //Following pointer will also points at the beginning to the first node.
            var followingPointer = list.StartNode;
            //Unless dead end.
            while (currentPointer != null)
            {
                //First we will move following pointer one step ahead.
                followingPointer = followingPointer.Link;
                //Now We will link the previous with the current pointer.
                currentPointer.Link = previousPointer;
                //Now bring previous to the current.
                previousPointer = currentPointer;
                //Next current pointer will be moved to following pointer.
                currentPointer = followingPointer;
            }

            //At the end all pointer except previous will be null .
            list.StartNode = previousPointer;
        }

        /// <summary>
        ///     Merged Sort
        /// </summary>
        /// <param name="list"></param>
        public static void MergedSort(SingleLinkedList<T> list)
        {
            //New Start Node .
            var newStartNode = MergeSortRecursion(list.StartNode);
            //Set it ti start node .
            list.StartNode = newStartNode;
        }

        #endregion

        #region Private Region

        /// <summary>
        ///     Merged sort recursion.
        /// </summary>
        private static SingleLinkListNode<T> MergeSortRecursion(SingleLinkListNode<T> startNode)
        {
            //First check the list should contain minimum two nodes.
            if (startNode == null) return startNode;

            if (startNode.Link == null) return startNode;

            //Divide the list in two part.0
            var firstListStartPoint = startNode;
            var secondListStartPoint = Divide(startNode);
            //apply recursion
            var startOne = MergeSortRecursion(firstListStartPoint);
            var startTwo = MergeSortRecursion(secondListStartPoint);
            //merge.
            var newListStartNode = Merge(startOne, startTwo);
            //return.
            return newListStartNode;
        }

        /// <summary>
        ///     Divide.
        /// </summary>
        private static SingleLinkListNode<T> Divide(SingleLinkListNode<T> currentNode)
        {
            //Take a pointer which points to the current node .
            var currentPointer = currentNode;
            //Take a pointer which points next node of the next node of the current node.
            var nextPointer = currentPointer.Link.Link;
            //check for null.
            while (nextPointer != null && nextPointer.Link != null)
            {
                //Move forward .
                currentPointer = currentPointer.Link;
                nextPointer = nextPointer.Link.Link;
            }

            //New node.
            var newStartNode = currentPointer.Link;
            //Break the list.
            currentPointer.Link = null;
            //Go to the next node of the current pointer .
            return newStartNode;
        }
    }

    #endregion
}