using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BinaryTree
{
	public class Node
	{
		private int value_;
		public int Value
		{
			get
			{
				return value_;
			}
			set {
				value_ = value;
			}
		}

		private Node leftNode_;
		public Node LeftNode
		{
			get
			{
				return leftNode_;
			}
			set
			{
				leftNode_ = value;
			}
		}

		private Node rightNode_;
		public Node RightNode
		{
			get
			{
				return rightNode_;
			}
			set
			{
				rightNode_ = value;
			}
		}

		public Node(int value) {
			value_ = value;
			leftNode_ = null;
			rightNode_ = null;
		}

		public void Print(int level = 0)
		{
			if (this.HasRightNode ()) {
				this.RightNode.Print (level + 1);
			}

			for (uint i = 0; i < level; ++i) {
				Console.Write("-");
			}
			Console.WriteLine("{0:D}", value_);

			if (this.HasLeftNode ()) {
				this.LeftNode.Print (level + 1);
			}
		}

		public bool HasRightNode()
		{
			return rightNode_ != null;
		}

		public bool HasLeftNode()
		{
			return leftNode_ != null;
		}

		public Node InsertChildWithValue(int value)
		{
			if (value > value_) {
				Node child = new Node(value);
				this.RightNode = child;
				return child;
			} else if (value < value_) {
				Node child = new Node(value);
				this.LeftNode = child;
				return child;
			} else {
				return this;
			}
		}
	}
}