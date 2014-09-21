using System;

namespace MergeSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] a = new int[] { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

			int[] aux = new int[a.Length];

			MergeSort (a, aux, 0, a.Length-1);
			foreach (int item in a) {

				Console.WriteLine (item);

			}

			Console.ReadLine ();
		}

		private static void MergeArray(int[] a , int[] aux, int low, int mid, int high)
		{
			for (int k = low; k <= high; k++) {
				aux[k] = a[k];
			}

			int i = low;
			int j = mid +1;

			for (int k = low; k <= high; k++) {
				if (i > mid)
					a [k] = aux [j++];
				else if (j > high)
					a [k] = aux [i++];
				else if (aux [j] < aux [i])
					a [k] = aux [j++];
				else
					a [k] = aux [i++];
				
			}

		}

		private static void MergeSort(int[] a, int[] aux,int low,int high)
		{
			if (high > low)
			{
				int mid = (low + high) / 2;
				MergeSort (a, aux, low, mid);
				MergeSort (a, aux, mid + 1, high);
				MergeArray (a, aux, low, mid, high);
			}
		}

	}
}
