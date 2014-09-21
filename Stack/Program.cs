using System;


namespace Stack
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Stack Example");
			StackOfString stck = new StackOfString ();
			string strInput = "temp";
			Console.WriteLine ("Enter Values On Stack");
			while (strInput != string.Empty) 
			{
				strInput = Console.ReadLine ();
				if (strInput.Equals("-"))
					{
						Console.WriteLine(stck.Pop());
					}
				else
					{
						stck.Push(strInput);
					}
			} 
		}
	}

	public class StackOfString
	{
		private Node first = null;
		private class Node
		{
			public string Item;
			public Node Next;
		}
		public bool IsEmpty()
		{
			return first == null;
		}
		public void Push(string strIn)
		{
			Node oldFirst = first;
			this.first = new Node ();
			first.Item = strIn;
			first.Next = oldFirst;
		}
		public string Pop()
		{
			if (this.IsEmpty()) {
				return "Empty";
			}
			string item = this.first.Item;
			first = first.Next;
			return item;
		}
	}
}
