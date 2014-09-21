using System;
using System.Collections;

// Find M largest item from array of N items

namespace PriorityQueue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			UnOrderedMaxPQ pq = new UnOrderedMaxPQ (9);
			Console.WriteLine (pq.isEmpty());
			pq.insert (0);
			pq.insert (2);
			pq.insert (1);
			pq.insert (10);
			pq.insert (3);
			pq.insert (9);
			Console.WriteLine (pq.deleteMax ());
			pq.insert (5);
			Console.WriteLine (pq.deleteMax ());
			Console.WriteLine (pq.deleteMax ());

		
			Console.ReadLine ();
		}
	}

	class UnOrderedMaxPQ 
	{
		private int[] pq;
		private int N;
		private int pos;

		public UnOrderedMaxPQ(int Capacity)
		{
			pq = new int[Capacity];
		}

		public bool isEmpty()
		{
			return N == 0;
		}

		public void insert(int x)
		{
			pq [N++] = x;
		}

		public int deleteMax()
		{
			int max = 0;
			for (int i = 0; i < N; i++) {
				if (pq [i] > max) {
					max = pq [i];
					pos = i;
				}
			}

			int temp = pq[N-1];
			pq [N - 1] = max;
			pq [pos] = temp;

			return pq [--N];
		}
	}
}
