using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        private Node rootNode_;
        public Node RootNode
        {
            get
            {
                return rootNode_;
            }
            set
            {
                rootNode_ = value;
            }
        }
        
        
        public Tree()
        {
            rootNode_ = null;
        }
        
        public Node InsertNodeWithValue(int value)
        {
<<<<<<< HEAD
            if (rootNode_ == null)
            {
                rootNode_.Value = value;
                return rootNode_;
            }
            Node currentNode = rootNode_;
            for (;;)
            {
                if (value > currentNode.Value)
                {
                    if (currentNode.hasRightNode(currentNode) != null)
                    {
                        currentNode = currentNode.RightNode;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                        currentNode.Value = value;
                        break;
                    }
                }
                if (value < currentNode.Value)
                {
                    if (currentNode.hasLeftNode(currentNode) != null)
                    {
                        currentNode = currentNode.LeftNode;
                    }
                    else
                    {
                        currentNode = currentNode.LeftNode;
                        currentNode.Value = value;
=======
            Node currentNode = rootNode_;
            for (;;) {
                if (  value > currentNode.GetValue() ) {
                    if ( currentNode.hasRightNode() ) {
                        currentNode = currentNode.getRightNode();
                    }
                    else {
>>>>>>> 64edd2f6d932f4b492d68fd458cc229c501cf1d9
                        break;
                    }
                }
            }
<<<<<<< HEAD
            return currentNode;
=======
>>>>>>> 64edd2f6d932f4b492d68fd458cc229c501cf1d9
        }
        
        public void Print()
        {
//          TODO
        }
        
        private static void Main()
        {
            Tree tree = new Tree();
            tree.InsertNodeWithValue(3);
            tree.InsertNodeWithValue(2);
            tree.InsertNodeWithValue(4);
            tree.InsertNodeWithValue(5);
            tree.Print();
//          TODO OUTPUT: 1
        }
    }
}
