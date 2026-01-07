namespace AiSD_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numAddValue = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnZig = new System.Windows.Forms.Button();
            this.btnZag = new System.Windows.Forms.Button();
            this.lblTreePrinted = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 397);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // numAddValue
            // 
            this.numAddValue.Location = new System.Drawing.Point(12, 415);
            this.numAddValue.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numAddValue.Name = "numAddValue";
            this.numAddValue.Size = new System.Drawing.Size(90, 23);
            this.numAddValue.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(173, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usun";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // lblDebug
            // 
            this.lblDebug.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDebug.Location = new System.Drawing.Point(426, 415);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDebug.Size = new System.Drawing.Size(362, 26);
            this.lblDebug.TabIndex = 4;
            this.lblDebug.Text = "Debug message goes here.";
            this.lblDebug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZig
            // 
            this.btnZig.Location = new System.Drawing.Point(238, 415);
            this.btnZig.Name = "btnZig";
            this.btnZig.Size = new System.Drawing.Size(49, 23);
            this.btnZig.TabIndex = 3;
            this.btnZig.Text = "Zig";
            this.btnZig.UseVisualStyleBackColor = true;
            this.btnZig.Click += new System.EventHandler(this.btnZig_Click);
            // 
            // btnZag
            // 
            this.btnZag.Location = new System.Drawing.Point(293, 415);
            this.btnZag.Name = "btnZag";
            this.btnZag.Size = new System.Drawing.Size(49, 23);
            this.btnZag.TabIndex = 3;
            this.btnZag.Text = "Zag";
            this.btnZag.UseVisualStyleBackColor = true;
            this.btnZag.Click += new System.EventHandler(this.btnZag_Click);
            // 
            // lblTreePrinted
            // 
            this.lblTreePrinted.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTreePrinted.Location = new System.Drawing.Point(173, 442);
            this.lblTreePrinted.Name = "lblTreePrinted";
            this.lblTreePrinted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTreePrinted.Size = new System.Drawing.Size(615, 26);
            this.lblTreePrinted.TabIndex = 4;
            this.lblTreePrinted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(108, 444);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "Pre",
            "In",
            "Post"});
            this.cmbOrder.Location = new System.Drawing.Point(58, 444);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(44, 23);
            this.cmbOrder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.lblTreePrinted);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnZag);
            this.Controls.Add(this.btnZig);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numAddValue);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown numAddValue;
        private Button btnAdd;
        private Button btnRemove;
        private System.ComponentModel.BackgroundWorker bw;
        private Label lblDebug;
        private Button btnZig;
        private Button btnZag;
        private Label lblTreePrinted;
        private Button btnPrint;
        private ComboBox cmbOrder;
        private Label label1;
    }
}