using System;

namespace Graph
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Graph g = new Graph (5);
			g.AddVertex (1.ToString());
			g.AddVertex (2.ToString());
			g.AddVertex (3.ToString());
			g.AddVertex (4.ToString());
			g.AddVertex (5.ToString());
			for (int i = 0; i < 5; i++) {
				Console.WriteLine ("Added Vertex : " + g.GetVertexAtIndex (i).label);
			}
			Vertex v1 = g.GetVertexAtIndex (0);
			Vertex v2 = g.GetVertexAtIndex (1);
			Vertex v4 = g.GetVertexAtIndex (4);
			Console.WriteLine ("Adding Edge Between ");
			Console.Write (" " + v1.label + " and " + v2.label);
			g.AddEdge (v1, v2);
			Console.Write (", " + v1.label + " and " + v4.label);
			g.AddEdge (v1, v4);
			Console.WriteLine ();
			Console.WriteLine ("Vertex Edges Connected to");
			g.ShowEdgesOfVertex (v1);

			Console.ReadLine ();
		}
	}

	public class Vertex
	{
		public bool wasVisited;
		public string label;

		public Vertex(string label)
		{
			this.label = label;
			this.wasVisited = false;
		}
	}

	public class Graph
	{
		private Vertex[] Vertices;
		private int[,] Edges;
		private int current;

		public Graph(int noOfvertices)
		{
			Vertices = new Vertex[noOfvertices];
			Edges = new int[noOfvertices, noOfvertices];
			current = 0;
			for (int i = 0; i < noOfvertices; i++) {

				for (int j = 0; j < noOfvertices; j++) {

					Edges [i, j] = 0;
				}

			}
		}

		public void AddVertex(string lbl)
		{
			if (current < Vertices.Length) {
				Vertex v = new Vertex (lbl);
				Vertices [current] = v;
				current++;

			}
		}

		public Vertex GetVertexAtIndex(int index)
		{
			return Vertices [index];
		}

		public int GetIndexOfVertex(Vertex v1)
		{
			for (int V = 0; V < Vertices.Length; V++) {
				if (v1.label == Vertices [V].label) {
					return V;
				} 
					

			}
			return -1;
		}

		public void AddEdge(Vertex v1, Vertex v2)
		{
			int indexV1 = GetIndexOfVertex (v1);
			int indexV2 = GetIndexOfVertex (v2);
			Edges [indexV1, indexV2] = 1;
			Edges [indexV2, indexV1] = 1;
		}

		public void ShowEdgesOfVertex(Vertex v)
		{
			int thisIndex = GetIndexOfVertex (v);
			Console.WriteLine (" Vertex Data is " + v.label);
			Console.WriteLine (" Edges are ");
			for (int i = 0; i < Edges.GetLength(0); i++) {
				if (Edges [thisIndex, i] == 1)
					Console.Write (GetVertexAtIndex (i).label + " ,");
			}
		}

	}
}
