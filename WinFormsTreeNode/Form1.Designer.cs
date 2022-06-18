
namespace WinFormsTreeNode
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Work");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Relax");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Study");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Documents", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("For Desktop");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("For File");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Painting", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeViewCatalog = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewCatalog
            // 
            this.treeViewCatalog.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeViewCatalog.Location = new System.Drawing.Point(75, 54);
            this.treeViewCatalog.Name = "treeViewCatalog";
            treeNode1.Name = "Work";
            treeNode1.Text = "Work";
            treeNode2.Name = "Relax";
            treeNode2.Text = "Relax";
            treeNode3.Name = "Study";
            treeNode3.Text = "Study";
            treeNode4.Name = "Documents";
            treeNode4.Text = "Documents";
            treeNode5.Name = "ForDesk";
            treeNode5.Text = "For Desktop";
            treeNode6.Name = "ForFile";
            treeNode6.Text = "For File";
            treeNode7.Name = "Painting";
            treeNode7.Text = "Painting";
            this.treeViewCatalog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeViewCatalog.Size = new System.Drawing.Size(234, 201);
            this.treeViewCatalog.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Catalog";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(75, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(234, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Delete Catalog";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeViewCatalog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCatalog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
    }
}

