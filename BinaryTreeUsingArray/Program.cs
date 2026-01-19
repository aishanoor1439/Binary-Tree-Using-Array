using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUsingArray
{
    internal class Program
    {
        class Array
        {
            static int root = 0;
            static String[] str = new String[10];

            public void Root(String key)
            {
                str[0] = key;
            }

            public void printTree()
            {
                for(int i = 0; i < 10; i++)
                {
                    if (str[i] != null)
                    {
                        Console.WriteLine(str[i]);

                    }
                    else 
                    {
                        Console.WriteLine("-");
                    }

                }
            }

            public void setLeft(String key, int root)
            {
                int t = (root * 2) + 1;

                if (str[root] == null)
                {
                    Console.Write("Can't set child at {0}, no parent found\n", t);
                }
                else
                {
                    str[t] = key;
                }
            }

            public void setRight(String key, int root)
            {
                int t = (root * 2) + 2;

                if (str[root] == null)
                {
                    Console.WriteLine("Can't set child at {0} no parent found\n", t);
                }
                else
                {
                    str[t] = key;
                }
            }

            public void preorder(int index)
            {
                if (index >= str.Length || str[index] == null)
                    return;

                Console.Write(str[index] + " ");     // Visit node
                preorder((index * 2) + 1);           // Left child
                preorder((index * 2) + 2);           // Right child
            }

            public void inorder(int index)
            {
                if (index >= str.Length || str[index] == null)
                    return;

                inorder((index * 2) + 1);            // Left child
                Console.Write(str[index] + " ");     // Visit node
                inorder((index * 2) + 2);            // Right child
            }

            public void postorder(int index)
            {
                if (index >= str.Length || str[index] == null)
                    return;

                postorder((index * 2) + 1);          // Left child
                postorder((index * 2) + 2);          // Right child
                Console.Write(str[index] + " ");     // Visit node
            }


        }
        static void Main(string[] args)
        {
            Array obj = new Array();

            obj.Root("A");
            obj.setLeft("B", 0);
            obj.setRight("C", 0);
            obj.setLeft("D", 1);
            obj.setRight("E", 1);
            obj.setLeft("F", 2);
            obj.setRight("G", 2);
            obj.printTree();

            Console.WriteLine("\nPreorder Traversal:");
            obj.preorder(0);

            Console.WriteLine("\n\nInorder Traversal:");
            obj.inorder(0);

            Console.WriteLine("\n\nPostorder Traversal:");
            obj.postorder(0);
        }
    }
}
