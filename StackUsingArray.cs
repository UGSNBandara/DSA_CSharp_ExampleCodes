using System;

namespace DSA_CSharp
{
    public class StackUsingArray<T>
    {
        private T[] stack;
        private int top;
        private int capacity;

        public StackUsingArray(int size)
        {
            stack = new T[size];
            top = -1;
            capacity = size;
        }

        public void Push(T data)
        {
            if(top == capacity - 1)
            {
                Console.WriteLine("Stack is overflow");
            }
            else
            {
                stack[++top] = data;
            }
        }

        public void pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Element popped is : " + stack[top--]);
            }
        }

        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Element at top is : " + stack[top]);
            }
        }

        public void PrintStack()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
