using System;

namespace DS.Binary_Tree.Binary_Search_Tree
{
    public class BinarySearchTree<T> : BinaryTree<T>
    {
        /// <summary>
        ///     Is empty .
        /// </summary>
        /// <returns></returns>
        private bool CheckIsEmpty()
        {
            return RootNode == null;
        }

        #region Insertion 

        /// <summary>
        /// Insert a value in the tree .
        /// </summary>
        /// <param name="valueToBeInserted"></param>
        public void InsertRecursive(T valueToBeInserted)
        {
            try
            {
                InsertRecursive(RootNode, valueToBeInserted);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        private BinaryTreeNode<T> InsertRecursive(BinaryTreeNode<T>  atNode, T valueToBeInserted)
        {

            if (atNode == null) return new BinaryTreeNode<T>(valueToBeInserted);
            if (atNode == new BinaryTreeNode<T>(valueToBeInserted))
            {
                throw new OperationCanceledException("Duplicate Key");
            }
            return  InsertRecursive(atNode > new BinaryTreeNode<T>(valueToBeInserted) ? 
                atNode.RightChildNode :
                atNode.LeftChildNode, valueToBeInserted);

        }

        
        /// <summary>
        ///     Insert a value in the tree .
        /// </summary>
        /// <param name="valueToBeInserted"></param>
        public void InsertIterative(T valueToBeInserted)
        {
            var newNode = new BinaryTreeNode<T>(valueToBeInserted);
            try{SetPosition(newNode);}
            catch (Exception e){Console.WriteLine("Error: " + e);}
        }

        private  void SetPosition(BinaryTreeNode<T> newNode)
        {
            var previousPointer = GetPosition(newNode);
            //Empty Tree .
            if (previousPointer == null)
            {
                RootNode = newNode;
                return;
            }

            if (newNode > previousPointer)
            {
                previousPointer.RightChildNode = newNode;
                return;
            }

            if (newNode < previousPointer)
            {
                previousPointer.LeftChildNode = newNode;
            }
        }

        private BinaryTreeNode<T> GetPosition(BinaryTreeNode<T> newNode)
        {
            //Set pointer to root node .
            var pointer = RootNode;
            //Previous Pointer to null .
            BinaryTreeNode<T> previousPointer = null;
            //Iterate unless you get null.
            while (!pointer.Equals(null))
            {
                previousPointer = pointer;

                if (newNode > pointer) pointer = pointer.RightChildNode;

                if (newNode < pointer) pointer = pointer.LeftChildNode;

                if (newNode == pointer) throw new OperationCanceledException("Duplicate Key Found .");
            }

            return previousPointer;
        }

        #endregion

        #region Searching

        /// <summary>
        /// Search A node .
        /// </summary>
        /// <param name="key"></param>
        public bool Search(T key)
        {
            var result = Search(RootNode, key);
            return result;
        }

        private bool Search(BinaryTreeNode<T> node, T key)
        {
            var searchedNode = new BinaryTreeNode<T>(key);
            var pointer = node;
            while (!node.Equals(null))
            {
                //Equal
                if (pointer == searchedNode) return true;
                //Greater.
                if (searchedNode > pointer)
                {
                    pointer = pointer.RightChildNode;
                    continue;
                }
                //Less.
                if (searchedNode < pointer)
                {
                    pointer = pointer.LeftChildNode;
                    continue;
                }

            }

            return false;

        }
        /// <summary>
        /// Search A node .
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IterativeSearch(T key)
        {
            var result = IterativeSearch(RootNode, key);
            return result;
        }
        private bool IterativeSearch(BinaryTreeNode<T> node, T key)
        {
            if (node == new BinaryTreeNode<T>(key))
            {
                return true;
            }

            if (node == null)
            {
                return false;
            }

            if (new BinaryTreeNode<T>(key) > node)
            {
                return IterativeSearch(node.RightChildNode, key);
            }

            if (new BinaryTreeNode<T>(key) < node)
            {
                return IterativeSearch(node.LeftChildNode, key);
            }

            return false;
        }
        #endregion

        #region Maximum Value Minimum Value 

        #region Max
        /// <summary>
        /// Get Max .
        /// </summary>
        /// <returns></returns>
        public void GetMax()
        {
            if (CheckIsEmpty()) { Console.Write("\n" + "Tree Is Empty" + "\n"); }
            var result = GetMax(root: RootNode);
            Console.Write("\nResult : "+result.ToString()+"\n");
        }
        
        private static BinaryTreeNode<T> GetMax(BinaryTreeNode<T> root)
        {
            var pointer = root;
            BinaryTreeNode<T> previousPointer = null;
            while (!pointer.Equals(null))
            {
                previousPointer = pointer;
                pointer = pointer.RightChildNode;
            }
            return previousPointer;
        }
        /// <summary>
        /// Get Max .
        /// </summary>
        /// <returns></returns>
        public void GetMaxRecursive()
        {
            if (CheckIsEmpty()) { Console.Write("\n"+"Tree Is Empty"+"\n");}
            var result = GetMaxRecursive(RootNode);
            Console.Write("\n"+"Result : " + result.ToString() + "\n");
        }
        private static BinaryTreeNode<T> GetMaxRecursive(BinaryTreeNode<T> node)
        {
            return node.RightChildNode.Equals(null) ? node 
                : GetMaxRecursive(node.RightChildNode);
        }
        #endregion

        #region Min

        /// <summary>
        /// Get Min .
        /// </summary>
        /// <returns></returns>
        public void GetMin()
        {
            if (CheckIsEmpty()) { Console.Write("\n" + "Tree Is Empty" + "\n"); }
            var result = GetMin(root: RootNode);
            Console.Write("\nResult : " + result.ToString() + "\n");
        }

        private static BinaryTreeNode<T> GetMin(BinaryTreeNode<T> root)
        {
            var pointer = root;
            BinaryTreeNode<T> previousPointer = null;
            while (!pointer.Equals(null))
            {
                previousPointer = pointer;
                pointer = pointer.LeftChildNode;
            }
            return previousPointer;
        }
        /// <summary>
        /// Get Min .
        /// </summary>
        /// <returns></returns>
        public void GetMinRecursive()
        {
            if (CheckIsEmpty()) { Console.Write("\n" + "Tree Is Empty" + "\n"); }
            var result = GetMinRecursive(RootNode);
            Console.Write("\n" + "Result : " + result.ToString() + "\n");
        }
        private static BinaryTreeNode<T> GetMinRecursive(BinaryTreeNode<T> node)
        {
            return node.LeftChildNode.Equals(null) ? node
                : GetMinRecursive(node.LeftChildNode);
        }
        #endregion
        #endregion

        #region Deletion

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="value"></param>
        private void Delete(T value)
        {
            //Start searching from the root node .
            var pointer = RootNode;
            //Parent of the pointer node .
            BinaryTreeNode<T> pointerNodeParent = null;
            //The node that will be searched .
            var searchedNode  = new BinaryTreeNode<T>(value);
            //Iterate unless not found
            while (pointer != null)
            {
                //What you are searching present in the root node .
                if(pointer == searchedNode) { break; }
                //pointer is set to parent .
                pointerNodeParent = pointer;
                //If greater move to right Child .
                if (searchedNode > pointer)
                {
                    pointer = searchedNode.RightChildNode;
                }
                //If smaller move to left child .
                if (searchedNode < pointer)
                {
                    pointer = searchedNode.LeftChildNode;
                }

            }
            //If no such node is present .
            if (pointer == null)
            {
                return;
            }

            //If node is found .
            //Case 1 : When Node have both child .
            //We need to find in order successor of the  node .
            BinaryTreeNode<T> inOrderSuccessor;
            BinaryTreeNode<T> parentOfInOrderSuccessor;
            if (pointer.RightChildNode != null && pointer.LeftChildNode != null)
            {
                //Set the parent of in order successor to the 
                parentOfInOrderSuccessor = pointer;
                //Move to the right child .
                inOrderSuccessor = pointer.RightChildNode;
                //Iterate until the last 
                while (inOrderSuccessor.LeftChildNode != null)
                {
                    parentOfInOrderSuccessor = inOrderSuccessor;
                    inOrderSuccessor = inOrderSuccessor.LeftChildNode;
                }
                //set the value of in order successor to the node that will be deleted .
                pointer.Info = inOrderSuccessor.Info;
                //Set the pointer to the in order successor node .
                pointer = inOrderSuccessor;
                //set the parent of pointer to the in order successor parent .
                pointerNodeParent = parentOfInOrderSuccessor;

            }
            //Case 2 : When node have only one child .
            BinaryTreeNode<T> child  = null ;
            //Have right child .
            if (pointer.RightChildNode != null)
            {
                child = pointer.RightChildNode;
            }
            //Have Left child .
            if (pointer.LeftChildNode != null)
            {
                child = pointer.LeftChildNode;
            }
            //Now if parent is null .
            //ie. The node will be deleted is a parent node .
            if (pointerNodeParent == null)
            {
                RootNode = child;
            }

            if (pointer == pointerNodeParent.LeftChildNode)
            {
                pointerNodeParent.LeftChildNode = child;
            }
            else
            {
                pointerNodeParent.RightChildNode = child;
            }
        }

        #endregion
    }
}