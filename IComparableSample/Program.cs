using System;
using System.Collections;

namespace IComparableSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ArrayList temp = new ArrayList ();
			Random rnd = new Random ();
			for (int i = 0; i < 10; i++) {
				int degree = rnd.Next (0, 50);
				temperature t = new temperature ();
				t.Temperature = degree;
				temp.Add (t);
			}

			temp.Sort ();
			foreach (temperature t in temp) {
				Console.WriteLine (t.Temperature);
			}
			Console.ReadLine ();
		}
	}

	class temperature:IComparable
	{
		protected double tempF;
		public int CompareTo(object obj)
		{
			if (obj == null)
				return 1;
			temperature othertemp = obj as temperature;
			if (othertemp != null)
				return this.tempF.CompareTo (othertemp.tempF);
			else
				return 1;
		}

		public double Temperature
		{
			get{ return this.tempF;}
			set{this.tempF = value;}
		}
	}
}
