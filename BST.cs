using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    class Node
    {
        public int Key;
        public Node Left, Right;

        public Node(int key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }
    class BST
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        public void Print()
        {
            InOrderTraversal(root);
        }

        public void Delete(int key)
        {
            root = DeleteRec(root, key);
        }

        private Node InsertRec(Node root, int key)
        {
            if (root == null)
            {
                return new Node(key);
            }
            if (key < root.Key)
            {
                root.Left = InsertRec(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = InsertRec(root.Right, key);
            }
            return root;
        }

        private void InsertIteratively(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return;
            }

            Node current = root;
            Node parent = null;

            while (current != null)
            {
                if (key < current.Key)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (key > current.Key)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    return;
                }
            }

            if (key < parent.Key)
            {
                parent.Left = new Node(key);
            }
            else if (key > parent.Key)
            {
                parent.Right = new Node(key);
            }
        }

        private Node DeleteRec(Node root, int key)
        {
            if (root == null)
            {
                return root;
            }

            if (key < root.Key)
            {
                root.Left = DeleteRec(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = DeleteRec(root.Right, key);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                else
                {
                    root.Key = FindMin(root.Right);
                    root.Right = DeleteRec(root.Right, root.Key);
                }
            }
            return root;
        }

        private int FindMin(Node root)
        {

            while (root.Left != null)
            {
                root = root.Left;
            }
            return root.Key;
        }

        private void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.WriteLine(root.Key);
                InOrderTraversal(root.Right);
            }
        }

        private void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Key);
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        private void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.WriteLine(root.Key);
            }
        }
    }
}