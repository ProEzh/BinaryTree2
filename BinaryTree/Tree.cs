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
                    } 
                    else {
                        break;
                    }
                }
                else {
                    break;
                }
            }
            
            return currentNode.InsertChildWithValue(value);
        }
        
        public void Print()
        {
            if (this.IsEmpty())
                Console.WriteLine("Дерева нет");
            Node currentNode = rootNode_;
            for (; ; )
            {
                if (currentNode.RightNode != null)
                {
                    currentNode = currentNode.RightNode;
                    Console.Write("-");
                    currentNode.Print();
                }
                else 
                {
                    Console.Write(currentNode.Value);
                    break;
                }
            }
        }
        
        private static void Main()
        {
            Tree tree = new Tree();
            tree.InsertNodeWithValue(3);
            tree.InsertNodeWithValue(2);
            tree.InsertNodeWithValue(4);
            tree.InsertNodeWithValue(5);
            tree.InsertNodeWithValue(6);
            tree.InsertNodeWithValue(7);
            tree.InsertNodeWithValue(8);
            tree.InsertNodeWithValue(9);
            tree.InsertNodeWithValue(10);
            tree.InsertNodeWithValue(11);
            tree.InsertNodeWithValue(12);
            tree.InsertNodeWithValue(13);
            tree.InsertNodeWithValue(14);
            tree.Print();
            //          TODO OUTPUT: 1
        }
    }
}