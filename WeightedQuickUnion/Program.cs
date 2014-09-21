using System;

// Best algo.
namespace WeightedQuickUnion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("Enter Length:");
			int i = Convert.ToInt32(Console.ReadLine());
			WeightedQuickUnionUF wquf = new WeightedQuickUnionUF (i);
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
					wquf.union (p, q);
					break;
				case 2:
					bool b = wquf.connected (p, q);
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

	public class WeightedQuickUnionUF
	{
		private int[] id;
		private int[] sz; 

		public WeightedQuickUnionUF(int N)
		{
			id = new int[N];
			sz = new int[N];
			for (int i = 0; i < N; i++) {
				id [i] = i;
				sz [i] = 1;
				Console.WriteLine (id[i].ToString ());

			}
		}

		private int root(int i)
		{
			int j = 1;
			while (id[i] != i) {
				i = id [i];
				Console.WriteLine ("Iteration:" + j.ToString ());
				j++;
			}
			return i;
		}

		public bool connected(int p, int q)
		{
			return root (p) == root (q);
		}

		public void union(int p, int q)
		{
			int i = root (p);
			int j = root (q);
			if (i == j)
				return;
			if (sz[i] < sz[j]) {
				id [i] = j;
				sz [j] += sz [i];
				Console.WriteLine ("Size of root " + j.ToString() + " is");
				Console.WriteLine (sz[j].ToString ());
			} else {
				id [j] = i;
				sz [i] += sz [j];
				Console.WriteLine ("Size of root " + i.ToString() + " is");
				Console.WriteLine (sz [i].ToString ());
			}
		}
	}


}
