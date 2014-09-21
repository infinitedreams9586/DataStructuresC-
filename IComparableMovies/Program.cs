using System;
using System.Collections;

namespace IComparableMovies
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ArrayList mArr = new ArrayList();
			Random rnd = new Random ();

			for (int i = 0; i < 50; i++) {
				Movie m = new Movie ();
				m.Name = "name " + i.ToString ();
				m.Rating = rnd.Next (0, 10);
				mArr.Add (m);

			}

			mArr.Sort ();
			mArr.Reverse ();

			foreach (Movie item in mArr) {
				Console.WriteLine (item.Name + " : " + item.Rating.ToString());
				
			}


		}
	}

	class Movie:IComparable
	{
		protected string name;
		protected int rating;
		public string Name
		{
			get {return this.name;}
			set { this.name = value; }
		}
		public int Rating
		{
			get { return this.rating; }
			set { this.rating = value; }
		}
		public int CompareTo(object m)
		{
			if (m == null)
				return 1;
			Movie tmpMovie = m as Movie;
			return this.Rating.CompareTo (tmpMovie.Rating);
		}


	}
}
