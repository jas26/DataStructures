using System;

namespace BinaryTree
{
    class BinaryTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

        }
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void insert(int d)
        {
            Node newNode = new Node();
            newNode.data = d;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(d > parent.data)
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                }
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.left);
            Console.Write(root.data + " ");
            DisplayTree(root.right);
        }
        public void DisplayTree()
        {
            DisplayTree(root);
        }

    
    static void Main(string[] args)
        {   
            BinaryTree bt = new BinaryTree();
            bt.insert(50);
            bt.insert(40);
            bt.insert(35);
            bt.insert(60);
            bt.insert(45);
            bt.insert(55);
            bt.insert(85);
            bt.DisplayTree();
        }
    }
}
