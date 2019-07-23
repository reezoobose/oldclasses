//using DS.CircularLinkedList;
//using DS.SingleLinkedList;
//using DS.DoublyLinkedList;
//using DS.Stack.ArrayImplementation;
//using DS.Stack.LinkedListImplementation;
//using DS.Queue.SingleLinkedListImplementation;

using System;
using DS.Binary_Tree;

namespace DS
{
    public static class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            /*
            var list = new SingleLinkListUserInterface<int>();
            while (true){ list.UserChoice();}
            */
            /*
            var list = new DoublyLinkedListUserInterface<int>();
            while (true) { list.UserChoice(); }
            */
            /*
            var list = new CircularLinkedListUserInterface<int>();
            while (true) { list.UserChoice(); }
            */
            /*
            var arrayImplementationOfStack = new StackUserInterface();
            while (true) arrayImplementationOfStack.UserChoice();
            */

            /*
            var linkedListImplementationOfStack = new StackUserInterface<int>();
            while (true) linkedListImplementationOfStack.UserChoice();
            */

            /*
            var queue = new QueueUserInterface();
            while (true) queue.UserChoice();
            */
            /*
            var queue = new QueueUserInterface<int>();
            while (true) queue.UserChoice();
            */
            /*
            var recursion = new Recursion.UserInterface();
            */
            var btree = new CreateBinaryTree();
            btree.CreatedBinaryTree.PrintTree();
            btree.CreatedBinaryTree.PreOrder();
            btree.CreatedBinaryTree.PreOrderIterative();
            btree.CreatedBinaryTree.InOrder();
            btree.CreatedBinaryTree.InOrderIterative();
            btree.CreatedBinaryTree.PostOrder();
            btree.CreatedBinaryTree.PostOrderIterative();
            btree.CreatedBinaryTree.LevelOrder();
            Console.ReadKey();
        }
    }
}
