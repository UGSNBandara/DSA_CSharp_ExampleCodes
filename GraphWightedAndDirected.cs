using System;


namespace DSA_CSharp
{
    public class GraphWightedAndDirected
    {
        public class Node
        {
            public int Weight;
            public int Destination;
            public Node Next;

            public Node(int to, int weight)
            {
                Weight = weight;
                Destination = to;
                Next = null;
            }
        }

        private Node[] Vertices;
        private int VerticesCount;

        public GraphWightedAndDirected(int vertices)
        {
            Vertices = new Node[vertices];
            VerticesCount = vertices;
        }

        public void AddNewEdge(int from, int to , int weight)
        {
            Node newNode = new Node(to, weight);

            if (Vertices[from] == null)
            {
                Vertices[from] = newNode; 
            }
            else
            {
                Node current = Vertices[from];

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void PrintGraph()
        {
            for(int i=0; i<VerticesCount; i++)
            {
                if (Vertices[i] != null)
                {
                    Node current = Vertices[i];
                    while(current != null)
                    {
                        Console.WriteLine("Edge from " + i + " to " + current.Destination + " with weight " + current.Weight);
                        current = current.Next;
                    }
                }
            }
        }


    }
}
