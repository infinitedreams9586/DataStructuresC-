using System;

namespace InsertionSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] a = new int[]{ 3, 4, 74, 2, 1, 56, 87,0,25,12,34,65,78,55,100,2,3,4,5,5,7,2,1 };
			for (int i = 0; i < a.Length; i++) {
				for (int j = i; j > 0; j--) {
					if (less (a [j], a [j - 1]))
						exch (a, j, j-1);
					else
						break;
				}
			}

			foreach (int item in a) {
				Console.WriteLine (item.ToString ());
				
			}
			Console.ReadLine ();
		}

		private static bool less(int current, int previous)
		{
			if (current < previous)
				return true;
			else
				return false;
		}

		private static void exch(int[] a, int current, int previous)
		{
			int temp = a [current];
			a [current] = a [previous];
			a [previous] = temp;
		}
	}


}
