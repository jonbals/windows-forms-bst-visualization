using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_6
{
    internal class BinarySearchTree
    {
        public BSTNode? root = null;

        public BinarySearchTree()
        {

        }

        public void Add(int value)
        {
            BSTNode newNode = new BSTNode(value);

            if(this.root == null)
            {
                this.root = newNode;
                return;
            }

            BSTNode temp = this.root;
            while(true)
            {
                if(newNode.value < temp.value)
                {
                    if(temp.left == null)
                    {
                        temp.left = newNode;
                        newNode.parent = temp;
                        return;
                    }
                    temp = temp.left;
                }
                else
                {
                    if(temp.right == null)
                    {
                        temp.right = newNode;
                        newNode.parent = temp;
                        return;
                    }
                    temp = temp.right;
                }
            }
        }

        public void Remove(int value)
        {
            BSTNode? node = root;
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

        public BSTNode? FindNodeWithID(int id)
        {
            return nodeIDSearch(this.root, id);
        }

        private BSTNode? nodeIDSearch(BSTNode? node, int id)
        {
            if (node == null)
                return null;

            if (node.GetUID() == id)
                return node;

            BSTNode? l = nodeIDSearch(node.left, id);
            if (l != null)
                return l;
            return nodeIDSearch(node.right, id);
        }

        public void RemoveNode(BSTNode node)
        {
            BSTNode? kandydat = null;

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
                    this.RemoveNode(kandydat);

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

        public BSTNode FindMin(BSTNode node)
        {
            BSTNode min = node;
            while(min.left != null)
            {
                min = min.left;
            }
            return min;
        }

        public void Zig(BSTNode x)
        {
            if (x.parent == null)
                return;
            if (x.parent.left != x)
                return;

            BSTNode y = x.parent;
            BSTNode? B = x.right;
            BSTNode? Ry = y.parent;

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

        public void Zag(BSTNode x)
        {
            if (x.parent == null)
                return;
            if (x.parent.right != x)
                return;

            BSTNode y = x.parent;
            BSTNode? B = x.left;
            BSTNode? Ry = y.parent;

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

    }
}
