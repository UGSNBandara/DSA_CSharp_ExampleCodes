using System;


namespace DSA_CSharp
{
    public class Doubley_LinkedList<T>
    {
        public class Node
        {
            public T Data;
            public Node Next;
            public Node Prev;

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        private int Count;
        private Node Head;
        private Node Tail;

        public Doubley_LinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public void AddFirst(T data)
        {
            Node newNode = new Node(data);
            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(T data)
        {
            Node newNode = new Node(data);
            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Prev = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public void AddAtIndex(int index, T data)
        {
            if (index <0 || index > Count)
            {
                Console.WriteLine("Invalid Index");
            }
            else
            {
                if(index == 0)
                {
                    AddFirst(data);
                }
                else if(index == Count)
                {
                    AddLast(data);
                }
                else
                {
                    Node newNode = new Node(data);
                    Node NodeAtIndex = GetNodeAtIndex(index);

                    newNode.Prev = NodeAtIndex.Prev;
                    NodeAtIndex.Prev.Next = newNode;
                    newNode.Next = NodeAtIndex;
                    NodeAtIndex.Prev = newNode;
                    Count++;

                }
            }
        }

        private Node GetNodeAtIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                return null;
            }
            else
            {
                Node current = null;
                if (index < Count / 2)
                {
                    current = Head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                }
                else
                {
                    current = Tail;
                    for (int i = Count - 1; i > index; i--)
                    {
                        current = current.Prev;
                    }
                }
                return current;
            }
        }

        public void RemoveFirst()
        {
            if(Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else if(Head == Tail)
            {
                Head = Tail = null;
                Count--;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                Count--;
            }
        }

        public void RemoveLast()
        {
            if(Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                if(Head == Tail)
                {
                    Head = Tail = null;
                }
                else
                {
                    Tail = Tail.Prev;
                    Tail.Next = null;
                }
                Count--;
            }
        }

        public void RemoveAtIndex(int index)
        {
            if(Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else if(index < 0 || index >= Count)
            {
                Console.WriteLine("Invalid Index");
            }
            else
            {
                if (index == 0)
                {
                    RemoveFirst();
                }
                else if (index == Count - 1)
                {
                    RemoveLast();
                }
                else
                {
                    Node AtIndex = GetNodeAtIndex(index);

                    AtIndex.Next.Prev = AtIndex.Prev;
                    AtIndex.Prev.Next = AtIndex.Next;
                    Count--;
                }
            }
        }

        public void PrintListForward()
        {
            if(Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node current = Head;
                while(current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

        public void PrintListReverse()
        {
            if(Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node current = Tail;
                while(current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Prev;
                }
                Console.WriteLine();
            }
        }

    }
}
