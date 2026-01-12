using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Tree
    {
        public Node? root = null;

        public Tree()
        {

        }

        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (this.root == null)
            {
                this.root = newNode;
                return;
            }

            Node temp = this.root;
            while (true)
            {
                if (newNode.value < temp.value)
                {
                    if (temp.left == null)
                    {
                        temp.left = newNode;
                        newNode.parent = temp;
                        return;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = newNode;
                        newNode.parent = temp;
                        return;
                    }
                    temp = temp.right;
                }
            }
        }

        public void RemoveByValue(int value)
        {
            Node? node = root;
            while(node != null)
            {
                if(node.value == value)
                {
                    RemoveNode(node);
                    return;
                }

                if(value < node.value)
                {
                    node = node.left;
                }    
                else
                {
                    node = node.right;
                }
            }
        }

        public Node? FindNodeWithID(int id)
        {
            return nodeIDSearch(this.root, id);
        }

        private Node? nodeIDSearch(Node? node, int id)
        {
            if (node == null)
                return null;

            if (node.GetUID() == id)
                return node;

            Node? l = nodeIDSearch(node.left, id);
            if (l != null)
                return l;
            return nodeIDSearch(node.right, id);
        }

        

        public void RemoveNode(Node node)
        {
            Node? kandydat = null;

            switch (node.CountChildren())
            {
                case 0:
                    node.Unparent();
                    break;

                case 1:

                    kandydat = node.Unchild();
                    node.Unparent(kandydat);
                    break;

                case 2:
                    kandydat = this.FindMin(node.right);
                    RemoveNode(kandydat);

                    node.Unparent(kandydat);

                    kandydat.left = node.left;
                    kandydat.left.parent = kandydat;
                    kandydat.right = node.right;

                    if (kandydat.right != null)
                        kandydat.right.parent = kandydat;

                    node.left = null;
                    node.right = null;

                    break;

            }

            if (node == this.root)
                this.root = kandydat;
        }

        public Node FindMin(Node node)
        {
            Node min = node;
            while(min.left != null)
            {
                min = min.left;
            }
            return min;
        }

        public void Zig(Node x)
        {
            if (x.parent == null)
                return;
            if (x.parent.left != x)
                return;

            Node y = x.parent;
            Node? B = x.right;
            Node? Ry = y.parent;

            x.right = y;
            y.parent = x;

            y.left = B;
            if(B != null)
                B.parent = y;

            x.parent = Ry;
            if(Ry == null)
                this.root = x;
            else
            {
                if (Ry.left == y)
                    Ry.left = x;
                else
                    Ry.right = x;
            }
        }

        public void Zag(Node x)
        {
            if (x.parent == null)
                return;
            if (x.parent.right != x)
                return;

            Node y = x.parent;
            Node? B = x.left;
            Node? Ry = y.parent;

            x.left = y;
            y.parent = x;

            y.right = B;
            if (B != null)
                B.parent = y;

            x.parent = Ry;
            if (Ry == null)
                this.root = x;
            else
            {
                if (Ry.left == y)
                    Ry.left = x;
                else
                    Ry.right = x;
            }
        }

        public enum PrintOrder
        {
            Pre,
            In,
            Post
        }

        public string ToStringDepthFirst(PrintOrder order)
        {
            return recursiveString(this.root, order);
        }

        private string recursiveString(Node? node, PrintOrder order)
        {
            if (node == null)
                return "";

            string s = "";

            if (order == PrintOrder.Pre)
                s += node.value.ToString() + " ";

            s += recursiveString(node.left, order);

            if (order == PrintOrder.In)
                s += node.value.ToString() + " ";

            s += recursiveString(node.right, order);

            if (order == PrintOrder.Post)
                s += node.value.ToString() + " ";

            return s;
        }

    }
}
