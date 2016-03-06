using System;
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
            tvProject.SelectedNode = node;
            // Get the nodetype
            NodeType nt = Tree.GetNodeType(node);

            if (nt == NodeType.Namespace)
                cmNsRemove.Enabled = nt == NodeType.Namespace;
            else
                cmClassAddConstructor.Enabled = nt != NodeType.Interface;
            // Show context menu
            cmNamespace.Show(tvProject, p);
        }

        private void cmNsAddClass_Click(object sender, EventArgs e)
        {
            NodeType nodeType = (NodeType) ((ToolStripMenuItem) sender).Tag;
            AddClass ac = new AddClass(nodeType, Tree.GetNamespace(tvProject.SelectedNode));

            if (ac.ShowDialog(this) == DialogResult.OK)
            {
                if (nodeType != NodeType.Interface)
                {
                    Class cls = new Class()
                    {
                        Accessibility = ac.Accessibility,
                        Name = ac.ClassName,
                        Namespace = Tree.GetNamespace(tvProject.SelectedNode),
                        IsAbstract = nodeType == NodeType.Abstract
                    };
                    if(ac.DefaultCtor)
                        cls.Constructors.Add(new Constructor() {Accessibility = ac.Accessibility, Class = cls});
                    cls.Namespace.Classes.Add(cls);
                    Program.Db.Class.Add(cls);
                    Program.Db.SaveChanges();
                    Tree.AddClass(tvProject.SelectedNode, cls);
                }
                else
                {
                    Interface intf = new Interface()
                    {
                        Accessibility = ac.Accessibility,
                        Name = ac.ClassName,
                        Namespace = Tree.GetNamespace(tvProject.SelectedNode)
                    };
                    intf.Namespace.Interfaces.Add(intf);
                    Program.Db.Interfaces.Add(intf);
                    Program.Db.SaveChanges();
                    Tree.AddInterface(tvProject.SelectedNode, intf);
                }
                tvProject.SelectedNode.Expand();
            }

            ac.Dispose();
        }

        private void cmNsAddNamespace_Click(object sender, EventArgs e)
        {
            AddNamespace an = new AddNamespace(Tree.GetNamespace(tvProject.SelectedNode));

            if (an.ShowDialog(this) == DialogResult.OK)
            {
                Namespace ns = new Namespace() {Name = an.Namespace};
                Tree.GetNamespace(tvProject.SelectedNode)?.Namespaces.Add(ns);
                Program.Db.SaveChanges();
                Tree.AddNamespace(tvProject.SelectedNode, ns);
                tvProject.SelectedNode.Expand();
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
