using System;

namespace BinarySearch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter int Array");
			int[] arr = new int[11]{2,4,6,8,10,12,14,16,18,20,22};
			Console.WriteLine ("Enter int to search");
			int key = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine (BinarySearch (arr, key));
			Console.ReadLine ();
		}

		public static int BinarySearch(int[] arr,int key)
		{
			int low = 0;
			int high = arr.Length - 1;
			while (low < high) 
			{
				int mid = low + (high - low)/ 2;
				if (key < arr [mid])
					high = mid - 1;
				else if (key > arr [mid])
					low = mid + 1;
				else
					return mid;
			}
			return -1;

		}
	}
}
