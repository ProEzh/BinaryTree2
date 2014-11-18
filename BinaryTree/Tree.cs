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
        
        public bool IsEmpty() {
            return rootNode_ == null;
        }
        
        public Node SetRootNodeWithValue(int value) {
            rootNode_ = new Node (value);
            return rootNode_;
        }
        
        public Node InsertNodeWithValue(int value)
        {
            if (this.IsEmpty ()) {
                return this.SetRootNodeWithValue (value);
            }
            
            Node currentNode = rootNode_;
            for (;;)
            {
                if (value > currentNode.Value)
                {
                    if ( currentNode.HasRightNode() )
                    {
                        currentNode = currentNode.RightNode;
                    }
                    else
                    {
                        break;
                    }
                }
                if (value < currentNode.Value) {
                    if (currentNode.HasLeftNode ()) {
                        currentNode = currentNode.LeftNode;
                    } else {
                        break;
                    }
                } else {
                    break;
                }
            }
            
            return currentNode.InsertChildWithValue(value);
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