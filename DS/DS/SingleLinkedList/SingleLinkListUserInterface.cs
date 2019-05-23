using System;

namespace DS.SingleLinkedList
{
    /// <summary>
    ///     Single link list user interface .
    /// </summary>
    public class SingleLinkListUserInterface<T>
    {
        /// <summary>
        ///     Single linked list .
        /// </summary>
        private readonly SingleLinkedList<T> _list;

        /// <summary>
        ///     SingleLinkListUserInterface .
        /// </summary>
        public SingleLinkListUserInterface()
        {
            _list = new SingleLinkedList<T>();
        }

        /// <summary>
        ///     Create list .
        /// </summary>
        private void CreateList()
        {
            //Ask user for number of initial element in the list .
            Console.Write("\n\nNumber of initial element in the list :  ");
            //Read input .
            var initialElementCount = Console.ReadLine();
            //it should be integer .
            var testInt = int.TryParse(initialElementCount, out var elementCount);
            //test int failed just return.
            if (!testInt) return;
            //Element count negative just return
            if (elementCount <= 0) return;
            //Take input
            Console.WriteLine("\n");
            for (var i = 0; i < elementCount; i++)
            {
                //Enter the input .
                Console.Write("Enter the {0} element : ", i + 1);
                //received input.
                var value = Console.ReadLine();
                //Convert input to type T .
                var inputReceived = (T) Convert.ChangeType(value, typeof(T));
                //Insert at the end of the list.
                _list.InsertionAtTheEndOfTheList(inputReceived);
            }
        }

        /// <summary>
        ///     Create a list with N numbers.
        /// </summary>
        private void CreateListWithNNumbers()
        {
            //Ask user for number of initial element in the list .
            Console.Write("\n\nNumber of N elements in the list :  ");
            //Read input .
            var initialElementCount = Console.ReadLine();
            //it should be integer .
            var testInt = int.TryParse(initialElementCount, out var elementCount);
            //test int failed just return.
            if (!testInt) return;
            //Element count negative just return
            if (elementCount <= 0) return;
            //Take input
            Console.WriteLine("\n");
            for (var i = 0; i < elementCount; i++)
            {
                //Convert input to type T .
                var inputReceived = (T) Convert.ChangeType(i, typeof(T));
                //Insert at the end of the list.
                _list.InsertionAtTheEndOfTheList(inputReceived);
            }
        }

        /// <summary>
        ///     Create a sorted single linked list.
        /// </summary>
        /// <returns></returns>
        private SingleLinkListNode<T> CreateSortedSingleList()
        {
            //Create a new node mark it as a start node .
            SingleLinkListNode<T> startNode = null;
            //End pointer .
            SingleLinkListNode<T> endPointer = null;
            //Ask user for number of initial element in the list .
            Console.Write("\n\nNumber of initial element in the list :  ");
            //Read input .
            var initialElementCount = Console.ReadLine();
            //it should be integer .
            var testInt = int.TryParse(initialElementCount, out var elementCount);
            //test int failed just return.
            if (!testInt) return null;
            //Element count negative just return
            if (elementCount <= 0) return null;
            //Take input
            Console.WriteLine("\n");
            for (var i = 0; i < elementCount; i++)
            {
                //Enter the input .
                Console.Write("Enter the {0} element : ", i + 1);
                //received input.
                var value = Console.ReadLine();
                //Convert input to type T .
                var inputReceived = (T) Convert.ChangeType(value, typeof(T));
                //Insert at the end of the list.
                if (startNode == null)
                {
                    startNode = new SingleLinkListNode<T>(inputReceived);
                    endPointer = startNode;
                }
                else
                {
                    //Create a new node .
                    var newNode = new SingleLinkListNode<T>(inputReceived);
                    //Check the sorting criteria.
                    if (endPointer <= newNode)
                    {
                        endPointer.Link = newNode;
                        endPointer = endPointer.Link;
                    }
                    else
                    {
                        throw new NullReferenceException("Not In sorted order");
                    }
                }
            }

            return startNode;
        }

        /// <summary>
        ///     User choice .
        /// </summary>
        public void UserChoice()
        {
            Console.WriteLine("======== User Choice ========");
            //Ask user for make a choice .
            Console.WriteLine("Actions can be performed on the list.\n\n");

            Console.WriteLine("======== ======== ========");
            //option 0 for Exit Program .
            Console.WriteLine(" [0] : Exit Program.");
            //option 1 for create list .
            Console.WriteLine(" [1] : Create List.");
            //option 2 for Display list .
            Console.WriteLine(" [2] : Display List.");
            //option 3 for Delete Last Node.
            Console.WriteLine(" [3] : Delete Last Node");
            //option 4 for count number of nodes in the list .
            Console.WriteLine(" [4] : Count Number Of Node.");
            //option 5 for Search node with value .
            Console.WriteLine(" [5] : Search Node With Value.");
            //option 6 for Insert End .
            Console.WriteLine(" [6] : Insert A Node At The End The List.");
            //option 7 for Insert After Node .
            Console.WriteLine(" [7] : Insert After A Node.");
            //option 8 for Insert After Node .
            Console.WriteLine(" [8] : Insert Before A Node.");
            //option 9 for Insert at a position .
            Console.WriteLine(" [9] : Insert At A position.");
            //option 10 Delete First Node .
            Console.WriteLine("[10] : Delete First Node.");
            //option 11 Delete Node With Value .
            Console.WriteLine("[11] : Delete Node With Value.");
            //option 12 Reverse Link list .
            Console.WriteLine("[12] : Reverse The link List.");
            //option 13 Bubble Sort.
            Console.WriteLine("[13] : Bubble Sort. By value.");
            //option 14 Bubble Sort.
            Console.WriteLine("[14] : Bubble Sort. By reference.");
            //option 15 List. Create a list of n numbers.
            Console.WriteLine("[15] : Create a linked list with n numbers.Starts from 0");
            //option 16  Merge Two list in a new list.
            Console.WriteLine("[16] : Merge Two Sorted Linked List In a New List");
            //option 17 Normal Merge Two list in by changing reference.
            Console.WriteLine("[17] : Merge Two Sorted Linked List");
            //option 18  Merge sort.
            Console.WriteLine("[18] : Merge sort Linked List");

            Console.WriteLine("======== ======== ========\n\n");
            //Ask user choice:
            Console.Write("Enter Your Choice :");
            //Select choice.
            var choice = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Invalid input"));
            //Switch over choices .
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    CreateList();
                    break;
                case 2:
                    SingleLinkedListUtilities<T>.PrintList(_list.StartNode);
                    break;
                case 3:
                    _list.DeleteLastNode();
                    break;
                case 4:
                    Console.WriteLine("\nNumber of Nodes = {0}\n\n",
                        SingleLinkedListUtilities<T>.GetNumberOfNodes(_list));
                    break;
                case 5:
                    Console.Write("\nSearch Node With Value : ");
                    var value = Console.ReadLine();
                    var converted = (T) Convert.ChangeType(value, typeof(T));
                    var result = SingleLinkedListUtilities<T>.Search(converted, out var position, _list);
                    if (result)
                    {
                        Console.WriteLine("\nFound At Position = {0}", position);
                    }
                    else
                    {
                        Console.WriteLine("\nValue {0} Not Found In The List", value);
                        SingleLinkedListUtilities<T>.PrintList(_list.StartNode);
                    }

                    break;
                case 6:
                    Console.Write("\nEnter The Value of the Node = ");
                    var input = Console.ReadLine();
                    var convertedInput = (T) Convert.ChangeType(input, typeof(T));
                    _list.InsertionAtTheEndOfTheList(convertedInput);
                    break;
                case 7:
                    Console.Write("\nEnter The Value of the Searched Node : ");
                    var searchedNodeValue = Console.ReadLine();
                    var searchedNodeValueConverted = (T) Convert.ChangeType(searchedNodeValue, typeof(T));
                    Console.Write("\nEnter The Value of the New Node : ");
                    var newNodeValue = Console.ReadLine();
                    var newNodeValueConverted = (T) Convert.ChangeType(newNodeValue, typeof(T));
                    _list.InsertionAfterANode(searchedNodeValueConverted, newNodeValueConverted);
                    break;
                case 8:
                    Console.Write("\nEnter The Value of the Searched Node : ");
                    var searchedNodeValueBefore = Console.ReadLine();
                    var searchedNodeValueConvertedBefore = (T) Convert.ChangeType(searchedNodeValueBefore, typeof(T));
                    Console.Write("\nEnter The Value of the New Node : ");
                    var newNodeValueBefore = Console.ReadLine();
                    var newNodeValueConvertedBefore = (T) Convert.ChangeType(newNodeValueBefore, typeof(T));
                    _list.InsertionBeforeANode(searchedNodeValueConvertedBefore, newNodeValueConvertedBefore);
                    break;
                case 9:
                    Console.Write("\nInsert At The Position : ");
                    var insertPositionInput = Console.ReadLine();
                    var insertPositionInputConverted = (int) Convert.ChangeType(insertPositionInput, typeof(T));
                    Console.Write("\nEnter The Value of the New Node : ");
                    var newNodeValueAtPosition = Console.ReadLine();
                    var newNodeValueAtPositionConverted = (T) Convert.ChangeType(newNodeValueAtPosition, typeof(T));
                    _list.InsertANewNodeAtPosition(insertPositionInputConverted, newNodeValueAtPositionConverted);
                    break;
                case 10:
                    _list.DeleteFirstNode();
                    break;
                case 11:
                    Console.Write("\nEnter The Value of the of the Node Which will be deleted : ");
                    var searchedNodeValueToDelete = Console.ReadLine();
                    var searchedNodeValueToDeleteConverted =
                        (T) Convert.ChangeType(searchedNodeValueToDelete, typeof(T));
                    _list.DeleteNodeWithValue(searchedNodeValueToDeleteConverted);
                    break;
                case 12:
                    SingleLinkedListUtilities<T>.ReverseLinkedList(_list);
                    break;
                case 13:
                    SingleLinkedListUtilities<T>.BubbleSortOne(_list);
                    break;
                case 14:
                    SingleLinkedListUtilities<T>.BubbleSortTwo(_list);
                    break;
                case 15:
                    CreateListWithNNumbers();
                    break;
                case 16:
                    Console.Write("\n Create First List.");
                    var firstListStartNode = CreateSortedSingleList();
                    Console.Write("\n Create Second List.");
                    var secondListStartNode = CreateSortedSingleList();
                    var mergedList =
                        SingleLinkedListUtilities<T>.MergeInNewList(firstListStartNode, secondListStartNode);
                    SingleLinkedListUtilities<T>.PrintList(mergedList);
                    break;
                case 17:
                    Console.Write("\n Create First List.");
                    var firstNewListStartNode = CreateSortedSingleList();
                    Console.Write("\n Create Second List.");
                    var secondNewListStartNode = CreateSortedSingleList();
                    var mergedNewList =
                        SingleLinkedListUtilities<T>.Merge(firstNewListStartNode, secondNewListStartNode);
                    SingleLinkedListUtilities<T>.PrintList(mergedNewList);
                    break;
                case 18:
                    SingleLinkedListUtilities<T>.MergedSort(_list);
                    break;
            }
        }
    }
}