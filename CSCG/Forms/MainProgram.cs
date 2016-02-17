using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CSCG.Helpers;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class MainProgram : Form
    {
        private Project Project { get; set; }
        private TreeHelper Tree { get; set; }

        public MainProgram(Project project)
        {
            InitializeComponent();
            Project = project;
            Tree = new TreeHelper(tvProject);

            Tree.LoadProject(Project);

            //lblProjectId.Text = $"Id: {project.ProjectId}";
            //lblProjectTitle.Text = $"Title: {project.Title}";
            //lblProjectNamespace.Text = $"Namespace: {project.Namespace}";
            //lblProjectCreated.Text = $"Created: {project.Created.ToShortDateString()} {project.Created.ToShortTimeString()}";
            //lblProjectUpdated.Text = $"Updated: {project.Updated.ToShortDateString()} {project.Updated.ToShortTimeString()}";
            
            ChangeView(ViewState.Project);
        }

        private void ChangeView(ViewState state)
        {
            while (tcProject.TabPages.Count > 0)
                tcProject.TabPages.RemoveAt(0);
            switch (state)
            {
                case ViewState.Project:
                    tcProject.TabPages.Add(tpProject);
                    tcProject.TabPages.Add(tpNamespaces);
                    break;
            }
        }

        private void tvProject_MouseUp(object sender, MouseEventArgs e)
        {
            // Show menu only if the right mouse button is clicked.
            if (e.Button != MouseButtons.Right)
                return;
            // Point where the mouse is clicked.
            Point p = new Point(e.X, e.Y);
            // Get the node that the user has clicked.
            TreeNode node = tvProject.GetNodeAt(p);
            if (node == null)
                return;

            // Select the node the user has clicked.
            // The node appears selected until the menu is displayed on the screen.
            //var oldSelectNode = tvProject.SelectedNode;
            tvProject.SelectedNode = node;
            // Get the nodetype
            NodeType nt = Tree.GetNodeType(node);

            if (nt == NodeType.Root || nt == NodeType.Namespace)
                cmNsRemove.Enabled = nt == NodeType.Namespace;

            else
                cmClassAddConstructor.Enabled = nt != NodeType.Interface;
            // Show context menu
            cmNamespace.Show(tvProject, p);
            // Highlight the selected node.
            //tvProject.SelectedNode = oldSelectNode;
        }

        private void cmNsAddClass_Click(object sender, EventArgs e)
        {
           /* NodeType nt = (NodeType)((ToolStripMenuItem) sender).Tag;
            TreeNode node = new TreeNode($"Je Moeder ({tvProject.SelectedNode.Text})");
            node.Tag = nt;
            node.ImageIndex = _imageIndices[nt];
            node.SelectedImageIndex = _imageIndices[nt];
            tvProject.SelectedNode.Nodes.Add(node);*/
        }

        private void cmNsAddNamespace_Click(object sender, EventArgs e)
        {
            AddNamespace an;
            if (Tree.GetNamespace(tvProject.SelectedNode) != null)
                an = new AddNamespace(Tree.GetNamespace(tvProject.SelectedNode));
            else 
                an = new AddNamespace(Project);

            if (an.ShowDialog(this) == DialogResult.OK)
            {
                Namespace ns = new Namespace() {Name = an.Namespace, Project = Project};
                (Tree.GetNamespace(tvProject.SelectedNode).Namespaces ?? Project.Namespaces).Add(ns);
                Program.Db.SaveChanges();
                Tree.AddNamespace(tvProject.SelectedNode, ns);
            }
            an.Dispose();
        }

        private void cmNsRemove_Click(object sender, EventArgs e)
        {
            TreeNode node = tvProject.SelectedNode;
            if ( MessageBox.Show($"Are you sure you want to delete the namespace: {node.Text}?", "You sure?",
                    MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Program.Db.Namespaces.Remove(Tree.GetNamespace(node));
                Program.Db.SaveChanges();
                Tree.RemoveNode(node);
            }
        }
    }
}
