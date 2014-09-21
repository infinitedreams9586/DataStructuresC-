using System;
using System.Collections;

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


			Graph gr = new Graph (10);

			gr.AddVertex ("A");
			gr.AddVertex ("B");
			gr.AddVertex ("C");
			gr.AddVertex ("D");
			gr.AddVertex ("E");
			gr.AddVertex ("F");
			gr.AddVertex ("G");
			gr.AddVertex ("H");
			gr.AddVertex ("I");
			gr.AddVertex ("J");

			Vertex m1 = gr.GetVertexAtIndex (0);
			Vertex m2 = gr.GetVertexAtIndex (1);
			Vertex m3 = gr.GetVertexAtIndex (2);
			Vertex m4 = gr.GetVertexAtIndex (3);
			Vertex m5 = gr.GetVertexAtIndex (4);
			Vertex m6 = gr.GetVertexAtIndex (5);
			Vertex m7 = gr.GetVertexAtIndex (6);
			Vertex m8 = gr.GetVertexAtIndex (7);
			Vertex m9 = gr.GetVertexAtIndex (8);
			Vertex m10 = gr.GetVertexAtIndex (9);

			gr.AddEdge (m1, m2);
			gr.AddEdge (m2, m3);
			gr.AddEdge (m3, m4);
			gr.AddEdge (m1, m5);
			gr.AddEdge (m5, m6);
			gr.AddEdge (m6, m7);
			gr.AddEdge (m1, m8);
			gr.AddEdge (m8, m9);
			gr.AddEdge (m9, m10);
			gr.DepthFirstSearch ();
			gr.BredthFirstSearch ();

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

		private int GetAdjUnvisitedVertex(int v)
		{
			for (int i = 0; i < Vertices.Length; i++) {
				if ((Edges[v,i] == 1) && (Vertices[i].wasVisited == false)) {
					//Console.WriteLine (" Adj. vertex visited? " + Vertices [i].wasVisited.ToString ());
					return i;

				}

			}
			return -1;
		}

		public void DepthFirstSearch()
		{
			Stack stck = new Stack ();
			Vertices [0].wasVisited = true;
			Console.WriteLine ();
			Console.WriteLine ( " Depth First Search Result ");
			Console.WriteLine (Vertices [0].label);
			stck.Push(0);
			while (stck.Count >0) {
				int v = GetAdjUnvisitedVertex (Convert.ToInt32(stck.Peek ()));
				if (v == -1)
					stck.Pop ();
				else {
					Vertices [v].wasVisited = true;
					Console.WriteLine (Vertices [v].label + " " + Vertices[v].wasVisited.ToString());
					stck.Push (v);
				}
			}

			for (int i = 0; i < Vertices.Length; i++) {
				GetVertexAtIndex (i).wasVisited = false;
			}

		}

		public void BredthFirstSearch()
		{
			Queue que = new Queue ();
			Vertices [0].wasVisited = true;
			Console.WriteLine (" Bredth First Search Result ");
			Console.WriteLine (Vertices [0].label);
			que.Enqueue (0);
			while (que.Count > 0) {
				int ver1 = (int)que.Dequeue ();
				int ver2 = GetAdjUnvisitedVertex (ver1);
				while (ver2 != -1) {
					Vertices [ver2].wasVisited = true;
					Console.WriteLine (Vertices [ver2].label);
					que.Enqueue (ver2);
					ver2 = GetAdjUnvisitedVertex (ver1);
				}

			}
		}

	}
}
