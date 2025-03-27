using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAlgoDSA_CSharp
{
    class GraphsAllgorithm
    {
        public void GraphsAllgorithm_test()
        {
            int vertices = 5;

            List<List<int>> Graph = new List<List<int>>(vertices);
            for (int i = 0; i < vertices; i++)
            {
                Graph.Add(new List<int>());
            }

            AddEdges(Graph, 0, 1);
            AddEdges(Graph, 0, 4);
            AddEdges(Graph, 1, 2);
            AddEdges(Graph, 1, 4);
            AddEdges(Graph, 1, 3);

            Console.WriteLine("BFS : ");
            BFS(Graph, 0, vertices);

            Console.WriteLine("DFS : ");
            preDFS(Graph, 0, vertices);


        }

        private static void AddEdges(List<List<int>> Graph, int u, int v)
        {
            Graph[u].Add(v);
            Graph[v].Add(u);
        }

        private static void BFS(List<List<int>> Graph, int s, int Vertices)
        {
            Queue<int> q = new Queue<int>();
            bool[] Visited = new bool[Vertices];

            Visited[s] = true;
            Console.WriteLine("Visited " + s);
            q.Enqueue(s);

            while (q.Count != 0)
            {
                int cs = q.Dequeue();

                foreach (int x in Graph[cs])
                {
                    if (!Visited[x])
                    {
                        Visited[x] = true;
                        q.Enqueue(x);
                        Console.WriteLine("Visited " + x);
                    }
                }
            }


        }

        private static void preDFS(List<List<int>> Graph, int s, int vertices)
        {
            bool[] visited = new bool[vertices];
            DFS(Graph, s, visited);
        }

        private static void DFS(List<List<int>> Graph, int s, bool[] visited)
        {
            visited[s] = true;
            Console.WriteLine("Visited " + s);

            foreach (int x in Graph[s])
            {
                if (!visited[x])
                {
                    DFS(Graph, x, visited);
                }
            }
        }
    }
}
