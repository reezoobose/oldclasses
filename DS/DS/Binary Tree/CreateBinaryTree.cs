namespace DS.Binary_Tree
{
    public class CreateBinaryTree
    {
        public readonly BinaryTree<char> CreatedBinaryTree;

        public CreateBinaryTree()
        {
            CreatedBinaryTree = new BinaryTree<char> {RootNode = new BinaryTreeNode<char>('P')};
            CreatedBinaryTree.RootNode.LeftChildNode = new BinaryTreeNode<char>('Q');
            CreatedBinaryTree.RootNode.RightChildNode = new BinaryTreeNode<char>('R');
            CreatedBinaryTree.RootNode.LeftChildNode.LeftChildNode = new BinaryTreeNode<char>('A');
            CreatedBinaryTree.RootNode.LeftChildNode.RightChildNode = new BinaryTreeNode<char>('B');
            CreatedBinaryTree.RootNode.RightChildNode.LeftChildNode = new BinaryTreeNode<char>('X');
        }
    }
}