using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTreeNode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeViewCatalog.CheckBoxes = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Nodes.Add(new TreeNode());
            treeViewCatalog.SelectedNode.Nodes.Add(treeNode);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            treeViewCatalog.SelectedNode.Nodes.Remove(treeViewCatalog.SelectedNode);
        }
    }
}
