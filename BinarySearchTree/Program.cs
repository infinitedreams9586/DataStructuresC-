using System;

namespace BinarySearchTree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			BinarySearchTree bst = new BinarySearchTree ();
			bst.Insert (23);
			bst.Insert (45);
			bst.Insert (16);
			bst.Insert (37);
			bst.Insert (3);
			bst.Insert (99);
			bst.Insert (22);
			Console.WriteLine ("Traversal");
			bst.InOrder (bst.root);
			Console.ReadLine ();
		}
	}

	public class Node
	{
		public int Data;
		public Node Left;
		public Node Right;

		public void DisplayNode()
		{
			Console.Write (Data.ToString() + " ");
		}
	}

	public class BinarySearchTree
	{
		public Node root;

		public BinarySearchTree()
		{
			root = null;
		}

		public void Insert (int i)
		{
			Node newNode = new Node ();
			newNode.Data = i;
			if (root == null)
				root = newNode;
			else {
				Node current = root;
				Node parent;
				while (true) {
					parent = current;
					if (i < current.Data) {
						current = current.Left;
						if (current == null) {
							parent.Left = newNode;
							break;
						}
					} else {
						current = current.Right;
						if (current == null) {
							parent.Right = newNode;
							break;
						}
					}
				}
			}


		}

		public void InOrder(Node theRoot)
		{
			if(theRoot != null)
			{
				InOrder (theRoot.Left);
				theRoot.DisplayNode ();
				InOrder (theRoot.Right);
			}
		}
	}
}
