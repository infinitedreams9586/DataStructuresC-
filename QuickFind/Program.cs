using System;

namespace QuickFind
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("Enter Length:");
			int i = Convert.ToInt32(Console.ReadLine());
			QuickFindUF quf = new QuickFindUF (i);
			int choice = 1;
			while (choice != 3) {
				Console.WriteLine ("Select operation");
				Console.WriteLine ("1. Add Connection");
				Console.WriteLine ("2. Check Connection");
				Console.WriteLine ("3. Exit");
				Console.WriteLine ("Enter your choice");
				choice = Convert.ToInt16 (Console.ReadLine ());
				int p = 0 ;
				int q = 0 ;
				if (choice != 3) {
					Console.WriteLine ("Add / Check connection between two points - select between 0 and " + (i - 1).ToString ());
					Console.WriteLine ("Enter point p ");
					p = Convert.ToInt16 (Console.ReadLine ());
					Console.WriteLine ("Enter point q ");
					q = Convert.ToInt16 (Console.ReadLine ());
				}
				switch (choice) {
				case 1:
					quf.Union (p, q);
					break;
				case 2:
					bool b = quf.Connected (p, q);
					Console.WriteLine ("Are both points connected ?");
					Console.WriteLine (b.ToString ());
					break;
				default:
					break;
				}

			}
			Console.ReadLine ();
		}
	}

	public class QuickFindUF
	{
		private int[] id;

		public QuickFindUF(int N)
		{
			id = new int[N];
			for (int i = 0; i < N; i++) {
				id [i] = i;
				Console.WriteLine (id [i].ToString ());
			}
		}

		public bool Connected(int p, int q)
		{
			return id [p] == id [q];
		}

		public void Union(int p, int q)
		{
			int pid = id [p];
			//int qid = id [q];
			for (int i = 0; i < id.Length; i++) {
				if (id [i] == pid)
					id [i] = id[q];
			}
		}
	}
}
