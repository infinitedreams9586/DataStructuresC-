using System;

namespace QuickSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] a = new int[] { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

			QuickSort (a, 0, a.Length);
			foreach (int item in a) {

				Console.WriteLine (item);

			}

			Console.ReadLine ();
		}

		private static int Partition(int[] a, int left, int right)
		{
			int start = left;
			int pivot = a [left];
			//choose next element
			left++;
			//decrease right, because N length means
			// N-1 index
			right--;

			while (true) {
				while (left <= right && a[left] <= pivot) {
					left++;
				}
				while (left <= right && a [right] > pivot) {
					right--;
				}

				// if cursor crossed, then take that element
				// and swap with pivot
				//if left > right, means cursor crossed at left -1
				//
				if (left > right) {
					a [start] = a [left - 1];
					a [left - 1] = pivot;
					return left;
				}
				// continue
				//swaping elements
				int temp = a [left];
				a [left] = a [right];
				a [right] = temp;

			}
		}

		private static void QuickSort(int[] a, int left, int right)
		{
			if (left < right) {
				int pivot = Partition (a, left, right);
				QuickSort (a, left, pivot - 1);
				QuickSort (a, pivot, right);
			}
		}
	}

}
