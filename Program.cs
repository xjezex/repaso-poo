using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolPOO

{
    class Program
    {

        public class Node
        {
            public int data { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        public class binaryTree
        {
            Node root;



            public Node newNode(int data)
            {
                Node x = new Node(data);
                return x;
            }

            public binaryTree()
            {
                root = null;
            }

            public void printInOrder()
            {
                printInOrder(root);
                Console.WriteLine();
            }

            private void printInOrder(Node temp)
            {
                if (temp != null)
                {
                    printInOrder(temp.left);
                    Console.Write(temp.data + " ");         
                    printInOrder(temp.right);
                }
            }

            public void Insertar(Node new_node )
            {
                if (root == null)
                {
                    root = new_node;
                }
                else
                {
                    Node prev = null;
                    Node temp = root;

                    while (temp != null)
                    {
                        prev = temp;
                        if (new_node.data < temp.data)
                        {
                            temp = temp.left;
                        }
                        else
                        {
                            temp = temp.right;
                        }
                    }
                    if (new_node.data < prev.data)
                    {
                        prev.left = new_node;
                    }
                    else
                    {
                        prev.right = new_node;
                    }
                }

            }
        }

      


        static void Main(string[] args)
        {
            binaryTree arbol = new binaryTree();
            Node new_node;

            new_node = arbol.newNode(10);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(15);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(5);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(80);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(25);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(1);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(1);
            arbol.Insertar(new_node);



            arbol.printInOrder();
            Console.ReadLine();

        }
    }
}
