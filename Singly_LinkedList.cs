using System;


namespace DSA_CSharp
{
    public class Singly_LinkedList<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data)
                {
                Data = data;
                Next = null;
                }
        }

        private int Count;
        private Node head;

        public Singly_LinkedList()
        {
            head = null;
            Count = 0;

        }

        public void AddLast(T data)
        {
            Node NewNode = new Node(data);

            if (head == null)
            {
                head = NewNode;
                Count++;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = NewNode;
                Count++;
            }

        }
        public void AddFirst(T data)
        {
            Node newnode = new Node(data);
            newnode.Next = head;
            head = newnode;
            Count++;

        }

        public void AddAtIndex(T data, int index)
        {
            Node newNode = new Node(data);
            Node temp ;
            if (index>Count || index < 0)
            {
                Console.WriteLine("Invalid Index");
                return;
            }
            if(head == null)
            {
                head = newNode;
                Count++;
            }
            else
            {
                Node current = head;
                for(int i =0; i < index-1; i++)
                {
                    current = current.Next;
                }
                temp = current.Next;
                current.Next = newNode;
                newNode.Next = temp;
                Count++;
            }
        }

        public void RemoveFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                head = head.Next;
                Count--;
            }

        }

        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                Count--;
            }

        }

        public void RemoveAtIndex(int index)
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else if (index > Count-1 || index < 0)
            {
                Console.WriteLine("Invalid Index");
            }
            else if(index == Count - 1)
            {
                RemoveLast();
            }
            else if(index == 0)
            {
                RemoveFirst();
            }
            else
            {
                Node current = head;
                for(int i = 0; i < index-1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                Count--;
            }

        }

        public void PrintList()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node current = head;
                while(current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

        public void RemoveByValue(T data)
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                // Beacuae we can not use == operator for T type
                if(head.Data.Equals(data))
                {
                    while(head != null && head.Data.Equals(data))
                    {
                        head= head.Next;
                    }

                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        if (current.Next.Next == null && current.Next.Data.Equals(data))
                        {
                            current.Next = null;
                            return;
                        }
                        else if (current.Next.Data.Equals(data))
                        {
                            current.Next = current.Next.Next;
                            Count--;
                        }
                        else
                        {
                            current = current.Next;
                        }
                    }
                }
            }

        }
        
    }
}
