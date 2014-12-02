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
						continue;
					}
					else
					{
						break;
					}
				}
				else if (value < currentNode.Value) {
					if (currentNode.HasLeftNode ()) {
						currentNode = currentNode.LeftNode;
						continue;
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
			if (!this.IsEmpty ()) {
				this.RootNode.Print();
			}
		}

        public bool SearchElementInTree(int value)
        {
            if ( this.IsEmpty() ) {
                Console.WriteLine("Дерево не заполнено");
                return false;
            }
        
            Node currentNode = rootNode_;
            for ( ;; ) {
                if ( value > currentNode.Value ) {
                    if ( currentNode.HasRightNode() ) {
                        currentNode = currentNode.RightNode;
                        continue;
                    }
                    else {
                        Console.WriteLine("Элемент не найден");
                        return false;
                    }
                }
                else if ( value < currentNode.Value ) {
                    if ( currentNode.HasLeftNode() ) {
                        currentNode = currentNode.LeftNode;
                        continue;
                    }
                    else {
                        Console.WriteLine("Элемент не найден");
                        return false;
                    }
                }
                else {
                    Console.WriteLine("Элемент найден");
                    return true;
                }
            }
        }

		public static void Main()
		{
			Tree tree = new Tree();
			tree.InsertNodeWithValue(7);
			tree.InsertNodeWithValue(3);
			tree.InsertNodeWithValue(11);
			tree.InsertNodeWithValue(5);
			tree.InsertNodeWithValue(1);
			tree.InsertNodeWithValue(15);
            tree.InsertNodeWithValue(6);
            tree.InsertNodeWithValue(4);
            tree.SearchElementInTree(1);
			tree.Print();
		}
	}
}