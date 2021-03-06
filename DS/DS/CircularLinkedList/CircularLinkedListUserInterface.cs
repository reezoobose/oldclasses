﻿using System;

namespace DS.CircularLinkedList
{
    /// <summary>
    ///     Circular Linked List User Interface .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class CircularLinkedListUserInterface<T>
    {
        //List .
        private readonly CircularLinkedList<T> _list;

        //Constructor.
        public CircularLinkedListUserInterface()
        {
            _list = new CircularLinkedList<T>();
        }

        /// <summary>
        ///     Create Circular linked list .
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
               _list.InsertEndOfaList(new CircularLinkedListNode<T>(inputReceived));
            }
        }

        /// <summary>
        ///     User choice .
        /// </summary>
        public void UserChoice()
        {
            InterFaceSetup();
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
                    CircularLinkedListUtilities<T>.DisplayCircularLinkedList(_list);
                    break;
                case 6:
                    Console.WriteLine("\nInsert The Node Value : ");
                    //received input.
                    var value = Console.ReadLine();
                    //Convert input to type T .
                    var inputReceived = (T) Convert.ChangeType(value, typeof(T));
                    //Insert at the end of the list.
                    _list.InsertEndOfaList(new CircularLinkedListNode<T>(inputReceived));
                    break;
                case 7:
                    Console.Write("\nInsertion After The Node With Value : ");
                    //received input.
                    var searchedValueOne = Console.ReadLine();
                    //Convert input to type T .
                    var searchedValueInputOne = (T) Convert.ChangeType(searchedValueOne, typeof(T));
                    Console.Write("\nInsert The New Node With Value : ");
                    var newNodeValueOne = Console.ReadLine();
                    //Convert input to type T .
                    var newNodeValueInputOne = (T) Convert.ChangeType(newNodeValueOne, typeof(T));
                    //insert after the node.
                    _list.InsertAfterANode(searchedValueInputOne, newNodeValueInputOne);
                    break;
                case 8:
                    Console.Write("\nInsertion Before The Node With Value : ");
                    //received input.
                    var searchedValueTwo = Console.ReadLine();
                    //Convert input to type T .
                    var searchedValueInputTwo = (T) Convert.ChangeType(searchedValueTwo, typeof(T));
                    Console.Write("\nInsert The New Node With Value : ");
                    var newNodeValueTwo = Console.ReadLine();
                    //Convert input to type T .
                    var newNodeValueInputTwo = (T) Convert.ChangeType(newNodeValueTwo, typeof(T));
                    //insert after the node.
                    _list.InsertionBeforeANode(searchedValueInputTwo, newNodeValueInputTwo);
                    break;
                case 3:
                    _list.DeleteLastNode();
                    break;
                case 9:
                    _list.DeleteFirstNode();
                    break;
                case 10:
                    Console.Write("\nDelete The Node With Value : ");
                    //received input.
                    var nodeWillBeDeleted = Console.ReadLine();
                    //Convert input to type T .
                    var nodeWillBeDeletedInput = (T) Convert.ChangeType(nodeWillBeDeleted, typeof(T));
                    //Node delete.
                    _list.DeleteNode(nodeWillBeDeletedInput);
                    break;
                case 11:
                    Console.WriteLine("\nInsert The Node Value : ");
                    //received input.
                    var valueAtTheBeginning = Console.ReadLine();
                    //Convert input to type T .
                    var inputReceivedAtTheBeginning = (T)Convert.ChangeType(valueAtTheBeginning, typeof(T));
                    //Insert at the end of the list.
                    _list.InsertBeginningOfaList(new CircularLinkedListNode<T>(inputReceivedAtTheBeginning));
                    break;
            }
        }

        /// <summary>
        ///     User Interface Setup.
        /// </summary>
        private void InterFaceSetup()
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
            Console.WriteLine(" [4] :[Not Implemented] Count Number Of Node.");
            //option 5 for Search node with value .
            Console.WriteLine(" [5] : Search Node With Value.");
            //option 6 for Insert End .
            Console.WriteLine(" [6] : Insert A Node At The End The List.");
            //option 7 for Insert After Node .
            Console.WriteLine(" [7] : Insert After A Node.");
            //option 8 for Insert Before Node .
            Console.WriteLine(" [8] : Insert Before A Node.");
            //option 9 Delete the first Node.
            Console.WriteLine(" [9] : Delete The First Node.");
            //option 10 Delete the first Node.
            Console.WriteLine(" [10] : Delete The Node.");
            //Option 11 Insertion At the beginning of the list.
            Console.WriteLine(" [11] : Insertion At the Beginning.");
        }
    }
}