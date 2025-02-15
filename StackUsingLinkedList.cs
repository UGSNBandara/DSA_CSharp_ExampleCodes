using System;


namespace DSA_CSharp
{
    public class StackUsingLinkedList<T>
    {
        public class Node
        {
            public Node Next;
            public T Data;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public void Push(T data)
        {
            Node newNode = new Node(data);

            newNode.Next = top;
            top = newNode;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {

                Console.WriteLine("Element popped is : " + top.Data);
                top = top.Next;
            }
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {

                Console.WriteLine("Element at top is : " + top.Data);
            }
        }

        public void PrintStack()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
