using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_6
{
    internal class BSTNode
    {
        public int value;
        public BSTNode? parent = null;
        public BSTNode? left = null;
        public BSTNode? right = null;

        private int UID;
        static private int s_IDCounter = 1;

        public BSTNode(int value)
        {
            this.value = value;
            this.UID = BSTNode.s_IDCounter;
            BSTNode.s_IDCounter += 1;
        }

        public int GetUID()
        {
            return this.UID;
        }

        public void Unparent(BSTNode dziecko = null)
        {
            if (this.parent == null)
            {
                if (dziecko != null)
                    dziecko.parent = null;
                return;
            }

            if (this.parent.left == this)
            {
                this.parent.left = null;
                if (dziecko != null)
                    this.parent.left = dziecko;
            }

            else if (this.parent.right == this)
            {
                this.parent.right = null;

                if (dziecko != null)
                    this.parent.right = dziecko;
            }


            if (dziecko != null)
                dziecko.parent = this.parent;

            this.parent = null;
        }

        public BSTNode Unchild()
        {
            BSTNode dziecko = null;
            if (this.left != null)
                dziecko = this.left;

            if (this.right != null)
                dziecko = this.right;

            dziecko.Unparent();
            return dziecko;
        }

        public void SwapTreePositionWith(BSTNode other)
        {
            if (this == other)
                return;

            BSTNode? thisNewParent = null;
            bool thisIsLeftChild = false;
            BSTNode? otherNewParent = null;
            bool otherIsLeftChild = false;
            if (this.parent != null)
            {
                if (this.parent.left == this)
                    thisIsLeftChild = true;
                else if (this.parent.right == this)
                    thisIsLeftChild = false;
                otherNewParent = this.parent;
            }
            if (other.parent != null)
            {
                if (other.parent.left == other)
                    otherIsLeftChild = true;
                else if (other.parent.right == other)
                    otherIsLeftChild = false;
                thisNewParent = other.parent;
            }
            this.parent = thisNewParent;
            other.parent = otherNewParent;

            BSTNode? temp = this.left;
            this.left = other.left;
            other.left = temp;

            temp = this.right;
            this.right = other.right;
            other.right = temp;
        }

        public int CountChildren()
        {
            int result = 0;
            if (this.left != null) 
                result++;

            if (this.right != null) 
                result++;

            return result;
        }
    }
}
