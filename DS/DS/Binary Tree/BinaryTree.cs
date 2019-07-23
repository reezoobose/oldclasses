using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DS.Queue.SingleLinkedListImplementation;
using DS.Stack;

namespace DS.Binary_Tree
{
    /// <summary>
    /// Binary Tree .
    /// </summary>
    public class BinaryTree<T>
    {
        /// <summary>
        /// Root Node.
        /// </summary>
        public  BinaryTreeNode<T> RootNode = null;

        /// <summary>
        /// Show Binary Tree.
        /// </summary>
        private void DisplayBinaryTree(BinaryTreeNode<T> currentNode , int level = 0)
        {
            int levelCount;
            if(currentNode == null) return;
            DisplayBinaryTree(currentNode.RightChildNode , level+1);
            Console.WriteLine();
            for (levelCount = 0; levelCount < level; levelCount++)
            {
                Console.Write("  ");
            }

            Console.Write(currentNode.Info);
            DisplayBinaryTree(currentNode.LeftChildNode,level+1);
        }

        /// <summary>
        /// Print Tree .
        /// </summary>
        public void PrintTree()
        {
            DisplayBinaryTree(RootNode);
            
        }

        #region Traversing 

        #region Preorder
        public void PreOrder()
        {
            Console.WriteLine("\n\n PreOrder Recursion : \n\n");
            PreOrderTraversing(RootNode);
        }

        private void PreOrderTraversing(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            Console.Write(node.Info);
            PreOrderTraversing(node.LeftChildNode);
            PreOrderTraversing(node.RightChildNode);
        }

        public void PreOrderIterative()
        {
            Console.WriteLine("\n\n PreOrder Iterative : \n\n");
            PreOrderIterative(RootNode);
        }


        private void PreOrderIterative(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            var stack = new Stack.LinkedListImplementation.Stack<BinaryTreeNode<T>>();
            stack.PushInStack(node);
            while (!stack.IsStackEmpty)
            {
                
                var nodeRemoved = stack.PopFromStack();
                Console.Write(nodeRemoved.Info);
                if (nodeRemoved.RightChildNode!=null)
                    stack.PushInStack(nodeRemoved.RightChildNode);
                if (nodeRemoved.LeftChildNode != null)
                    stack.PushInStack(nodeRemoved.LeftChildNode);

            }

        }
        #endregion

        #region Inorder
        public void InOrder()
        {
            Console.WriteLine("\n\n InOrder Recursion: \n\n");
            InOrderTraversing(RootNode);
        }


        private void InOrderTraversing(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            InOrderTraversing(node.LeftChildNode);
            Console.Write(node.Info);
            InOrderTraversing(node.RightChildNode);
        }

        public void InOrderIterative()
        {
            Console.WriteLine("\n\n InOrder Iterative: \n\n");
            InOrderIterative(RootNode);
        }

        private void InOrderIterative(BinaryTreeNode<T> node)
        {
            if(node == null )return;
            var stack = new Stack.LinkedListImplementation.Stack<BinaryTreeNode<T>>();
            var pointer = node;
            while (true)
            {
                if (pointer != null)
                {
                    stack.PushInStack(pointer);
                    pointer = pointer.LeftChildNode;

                }
                else
                {
                    if(stack.IsStackEmpty)break;
                    pointer = stack.PopFromStack();
                    Console.Write(pointer.Info);
                    pointer = pointer.RightChildNode;

                }
            }
        }


        #endregion


        #region PostOrder

        public void PostOrder()
        {
            Console.WriteLine("\n\n PostOrder recursive: \n\n");
            PostOrder(RootNode);
        }

        private void PostOrder(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            PostOrder(node.LeftChildNode);
            PostOrder(node.RightChildNode);
            Console.Write(node.Info);
        }

        public void PostOrderIterative()
        {
            Console.WriteLine("\n\n [OnProgress: ]PostOrder Iterative: \n\n");
            //PostOrderIterative(RootNode);
        }
        private void PostOrderIterative(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            var stackOne = new Stack.LinkedListImplementation.Stack<BinaryTreeNode<T>>();
            var stackTwo = new Stack.LinkedListImplementation.Stack<BinaryTreeNode<T>>();
            stackOne.PushInStack(node);
            while (!stackOne.IsStackEmpty)
            {



                Console.WriteLine("============Iteration Started=============");


                Console.WriteLine("\n\n\n========Before Start Check First Stack=====================\n\n\n");
                try
                {
                    Console.WriteLine("\nBefore Pop \n");
                    Console.WriteLine("Stack One: ");
                    stackOne.Display();
                }
                catch
                {
                    Console.WriteLine("Empty Stack");
                }
                Console.WriteLine("\n\n\n========First Stack Check Complete=====================\n\n\n");





                var removedElementFromStackOne = stackOne.PopFromStack();
                Console.WriteLine("\n\n\n========After Pop Check First Stack=====================\n\n\n");
                try
                {
                    Console.WriteLine("\nAfter Pop : \n");
                    Console.WriteLine("Stack One: ");
                    stackOne.Display();
                }
                catch
                {
                    Console.WriteLine("Empty Stack");
                }
                Console.WriteLine("\n\n\n========First Stack Check complete=====================\n\n\n");





                Console.WriteLine("\n\n\n========Going To Push In Second Stack=====================\n\n\n");
                Console.Write("\nRemoved from Stack One : " + removedElementFromStackOne.Info);
                Console.WriteLine("\n");
                Console.ReadKey();
                stackTwo.PushInStack(removedElementFromStackOne);
                Console.WriteLine("\n");
                Console.Write("Inserted In stack Two  " + removedElementFromStackOne.Info);
                Console.ReadKey();
                try
                {
                    Console.WriteLine("\nAfter push : \n");
                    Console.WriteLine("Stack Two: ");
                    stackTwo.Display();
                }
                catch
                {
                    Console.WriteLine("Empty Stack");
                }

                Console.WriteLine("\n\n\n========Push complete Second Stack Checked=====================\n\n\n");





                if (removedElementFromStackOne.LeftChildNode != null)
                {
                    Console.WriteLine("\n\n\n========Going To Push Left Child In First Stack=====================\n\n\n");
                    Console.WriteLine("\n");
                    Console.Write("Left Child Found " + removedElementFromStackOne.LeftChildNode.Info);
                    Console.ReadKey();
                    stackOne.PushInStack(removedElementFromStackOne.LeftChildNode);
                    Console.WriteLine("\n");
                    Console.Write("Left Child inserted in stack One  " + removedElementFromStackOne.LeftChildNode.Info);
                    Console.ReadKey();
                    try
                    {
                        Console.WriteLine("\nAfter Left child push : \n");
                        Console.WriteLine("Stack One: ");
                        stackOne.Display();
                    }
                    catch
                    {
                        Console.WriteLine("Empty Stack");
                    }
                    Console.WriteLine("\n\n\n========Left Child Push Completed =====================\n\n\n");
                }

                if (removedElementFromStackOne.RightChildNode != null)
                {
                    Console.WriteLine("\n\n\n========Going To Push Right Child In First Stack=====================\n\n\n");
                    Console.WriteLine("\n");
                    Console.Write("Right Child Found " + removedElementFromStackOne.RightChildNode.Info);
                    Console.ReadKey();
                    stackOne.PushInStack(removedElementFromStackOne.RightChildNode);
                    Console.WriteLine("\n");
                    Console.Write("Right Child Inserted In Stack One " + removedElementFromStackOne.RightChildNode.Info);
                    Console.ReadKey();
                    try
                    {
                        Console.WriteLine("\nAfter Right child push : \n");
                        Console.WriteLine("Stack One: ");
                        stackOne.Display();
                    }
                    catch
                    {
                        Console.WriteLine("Empty Stack");
                    }
                    Console.WriteLine("\n\n\n========Right Child Push Completed =====================\n\n\n");

                }

                Console.WriteLine("\n\n\n============All Stack Status=============\n\n");
                try
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Stack Two: ");
                    stackTwo.Display();
                }
                catch
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Empty Stack Two");
                }

                try
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Stack One: ");
                    stackOne.Display();
                }
                catch
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Empty Stack One");
                }

                Console.WriteLine("============Iteration Completed=============");
            }

        }

        #endregion

        #region Level Order Taraversal

        public void LevelOrder()
        {
            LevelOrder(RootNode);
        }

        private void LevelOrder(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            var queue = new QueueLinkedListImplementation<BinaryTreeNode<T>>();
            queue.Enqueue(node);
            while (queue.SizeofQueue() > 0)
            {

                try
                {
                    var removedElementFromQueue = queue.Dequeue();
                    Console.Write(removedElementFromQueue.Info);
                    if (removedElementFromQueue.LeftChildNode != null)
                    {
                        queue.Enqueue(removedElementFromQueue.LeftChildNode);
                    }

                    if (removedElementFromQueue.RightChildNode != null)
                    {
                        queue.Enqueue(removedElementFromQueue.RightChildNode);
                    }
                }
                catch
                {
                    Console.WriteLine("empty queue reached.");
                }
                
            }
        }

        #endregion
        #endregion

    }
}
