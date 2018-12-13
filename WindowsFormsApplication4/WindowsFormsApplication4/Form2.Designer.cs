namespace WindowsFormsApplication4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("students", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("rooms", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("calculator");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("utilities", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.mex = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.mex)).BeginInit();
            this.mex.Panel1.SuspendLayout();
            this.mex.SuspendLayout();
            this.SuspendLayout();
            // 
            // mex
            // 
            this.mex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mex.Location = new System.Drawing.Point(0, 0);
            this.mex.Name = "mex";
            // 
            // mex.Panel1
            // 
            this.mex.Panel1.Controls.Add(this.treeView1);
            this.mex.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mex_Panel1_Paint);
            // 
            // mex.Panel2
            // 
            this.mex.Panel2.Text = global::WindowsFormsApplication4.Properties.Settings.Default.aaa;
            this.mex.Size = new System.Drawing.Size(325, 336);
            this.mex.SplitterDistance = 136;
            this.mex.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node0";
            treeNode4.Text = "students";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node4";
            treeNode8.Text = "rooms";
            treeNode9.Name = "calculator";
            treeNode9.Text = "calculator";
            treeNode10.Name = "utilities";
            treeNode10.Text = "utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(133, 336);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 336);
            this.Controls.Add(this.mex);
            this.Name = "Form2";
            this.Text = "Form2";
            this.mex.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mex)).EndInit();
            this.mex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mex;
        private System.Windows.Forms.TreeView treeView1;


    }
}