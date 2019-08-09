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

            public void Insertar(Node new_node)
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
                        if (new_node.data > prev.data)
                        {
                            prev.right = new_node;
                        }
                    }
                }

            }

            /*print list*/

            public void printInOrder()
            {
                PrintInOrder(root);
                Console.WriteLine();
            }

            private void PrintInOrder(Node temp)
            {
                if (temp != null)
                {
                    PrintInOrder(temp.left);
                    Console.Write(temp.data + " ");
                    PrintInOrder(temp.right);
                }
            }



            /*****ALTURA********/
            public void height()
            {
                Console.Write("Altura: ");
                Console.WriteLine(height(root));
            }
            int height(Node root)
            {
                Node temp = root;
                int treeHeight; int left = 0; int right = 0;
                while (temp != null)
                {
                    left += 1;
                    temp = temp.left;
                }
                temp = root;
                while (temp != null)
                {
                    right += 1;
                    temp = temp.right;
                }
                if (left > right)
                {
                    treeHeight = left;
                }
                else
                {
                    treeHeight = right;
                }

                return treeHeight;
            }
            /*****************************/

            public void TotalNodes()
            {
                TotalNodes(root);
                Console.Write("Cantidad de Nodos: ");
                Console.WriteLine(TotalNodes(root));
            }
            int TotalNodes(Node root)
            {
                Node temp = root;
                int total = 1;

                if (temp.left != null)
                {
                    total += TotalNodes(temp.left);
                }

                if (temp.right != null)
                {
                    total += TotalNodes(temp.right);
                }

                return total;
            }

            public void returnMax()
            {
                Console.WriteLine("Valor Maximo del arbol: " + returnMax(root));
            }
            public int returnMax(Node root)
            {
                int max;
                Node temp = root;
                Node prev = root;
                while (temp != null)
                {
                    prev = temp;
                    temp = temp.right;
                }
                max = prev.data;

                return max;
            }

            public void returnMin()
            {
                Console.WriteLine("Valor Minimi del arbol: " + returnMin(root));
            }
            static int returnMin(Node root)
            {
                int max;
                Node temp = root;
                Node prev = root;
                while (temp != null)
                {
                    prev = temp;
                    temp = temp.left;
                }
                max = prev.data;

                return max;
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

            new_node = arbol.newNode(95);
            arbol.Insertar(new_node);

            new_node = arbol.newNode(185);
            arbol.Insertar(new_node);

            arbol.printInOrder();

            arbol.height();

            arbol.TotalNodes();

            arbol.returnMax();

            arbol.returnMin();
          
            Console.ReadLine();

        }
    }
}
