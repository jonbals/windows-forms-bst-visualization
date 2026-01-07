namespace AiSD_6
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black, 2);
        SolidBrush nodeBrush = new SolidBrush(Color.White);
        SolidBrush selectedNodeBrush = new SolidBrush(Color.LightSalmon);
        SolidBrush textBrush = new SolidBrush(Color.Black);
        const int fontSize = 14;
        Font font = new Font("Calibri", fontSize);
        const int circleRadius = 20;
        BinarySearchTree bst;
        int selectedNodeID = 0;
        BSTNode? selectedNode = null;
        Dictionary<int, Point> nodePositionsDict = new Dictionary<int, Point>();

        public Form1()
        {
            InitializeComponent();

            bst = new BinarySearchTree();
            btnZig.Enabled = false;
            btnZag.Enabled = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(bst.root != null)
            {
                nodePositionsDict.Clear();
                drawNodes(bst.root, pictureBox1.Left, pictureBox1.Right, 0, g);
            }
        }

        private void drawNodes(BSTNode node, int l, int r, int depth, Graphics g)
        {
            int c = (l + r) / 2;
            int y = 50 + (50 * depth);

            Point circleCenter = new Point(c, y);
            nodePositionsDict.Add(node.GetUID(), circleCenter);

            if (node.left != null)
            {
                int toC = (l + c) / 2;
                int toY = y + 50;
                g.DrawLine(pen, c, y, toC, toY);
                drawNodes(node.left, l, c, depth + 1, g);
            }
            if (node.right != null)
            {
                int toC = (c + r) / 2;
                int toY = y + 50;
                g.DrawLine(pen, c, y, toC, toY);
                drawNodes(node.right, c, r, depth + 1, g);
            }

            Rectangle circleRect = new Rectangle();
            circleRect.X = c - circleRadius;
            circleRect.Width = circleRadius * 2;
            circleRect.Y = y - circleRadius;
            circleRect.Height = circleRadius * 2;

            if(selectedNodeID == node.GetUID())
                g.FillEllipse(selectedNodeBrush, circleRect);
            else
                g.FillEllipse(nodeBrush, circleRect);
            g.DrawEllipse(pen, circleRect);

            g.DrawString(node.value.ToString(), font, textBrush, c - circleRadius + 5, y - (fontSize / 2) - 2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int valueToAdd = (int)numAddValue.Value;
            bst.Add(valueToAdd);
            pictureBox1.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int valueToRemove = (int)numAddValue.Value;
            bst.Remove(valueToRemove);
            pictureBox1.Refresh();
        }

        private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                //
                Thread.Sleep(200);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            String debugMsg = "";
            Point clickPos = e.Location;
            selectedNodeID = 0;
            foreach(var(id, pos) in nodePositionsDict)
            {
                float distance = MathF.Sqrt(MathF.Pow(clickPos.X - pos.X, 2.0f) + MathF.Pow(clickPos.Y - pos.Y, 2.0f));
                if(distance <= circleRadius)
                {
                    selectedNodeID = id;
                    pictureBox1.Refresh();
                    break;
                }
            }
            pictureBox1.Refresh();

            selectedNode = bst.FindNodeWithID(selectedNodeID);
            btnZig.Enabled = selectedNode != null;
            btnZag.Enabled = selectedNode != null;

            debugMsg += String.Format("clickPos: ({0}, {1})", clickPos.X, clickPos.Y);
            lblDebug.Text = debugMsg;
        }

        private void btnZig_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
                return;

            bst.Zig(selectedNode);
            pictureBox1.Refresh();
        }

        private void btnZag_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
                return;

            bst.Zag(selectedNode);
            pictureBox1.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BinarySearchTree.PrintOrder order = 0;
            string comboValue = cmbOrder.SelectedItem.ToString();
            switch(comboValue)
            {
                case "Pre":
                    order = BinarySearchTree.PrintOrder.Pre;
                    break;
                case "In":
                    order = BinarySearchTree.PrintOrder.In;
                    break;
                case "Post":
                    order = BinarySearchTree.PrintOrder.Post;
                    break;
            }
            lblTreePrinted.Text = bst.ToStringDepthFirst(order);
        }
    }
}