using System;
using System.Collections;

namespace HeapSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Heap h = new Heap (5);
			h.insert (1);
			h.insert (3);
			h.insert (2);
			h.insert (5);
			h.insert (4);
			Console.WriteLine ("Sorted Elements are :");
			for (int i = 0; i < h.Length(); i++) {
				Console.WriteLine (h.GetValueAtIndex (i).ToString ());
			}
			Console.ReadLine ();
		}




	}

	class Heap
	{
		int[] arr;
		int current = 0;
		public Heap(int length)
		{
			arr = new int[length];
		}

		public int Length()
		{
			return arr.Length;
		}

		public int GetValueAtIndex(int x)
		{
			return arr [x];
		}

		public void insert(int x)
		{
			arr [current] = x;
			Swim (arr, current);
			current++;
		}

		public void Swim(int[] arr, int k)
		{
			while ((k >= 1) && (arr[k/2] < arr[k])) {

				int temp = arr [k / 2];
				arr [k / 2] = arr [k];
				arr [k] = temp;
				k = k / 2;

			}
		}
	}
}
