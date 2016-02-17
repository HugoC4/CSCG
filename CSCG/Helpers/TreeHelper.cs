using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Code;
using CSCG.Models;

namespace CSCG.Helpers
{
    class TreeHelper
    {
        private readonly Dictionary<NodeType, int> _imageIndices = new Dictionary<NodeType, int>
        {
            { NodeType.Root, 0 },
            { NodeType.Namespace, 0 },
            { NodeType.Class, 1 },
            { NodeType.Abstract, 2 },
            { NodeType.Interface, 3 },
            { NodeType.Property, 4 },
            { NodeType.Field, 5 },
            { NodeType.Constructor, 6 },
            { NodeType.Method, 7 },
        };
        private TreeView Tree { get; set; }
        public TreeHelper(TreeView treeView)
        {
            Tree = treeView;
        }

        public void LoadProject(Project project)
        {
            TreeNode node = AddRoot(project);
            LoadNamespaces(node, project.Namespaces);
        }

        private void LoadNamespaces(TreeNode parent, List<Namespace> namespaces)
        {
            foreach (var ns in namespaces)
            {
                TreeNode node = AddNamespace(parent, ns);
                LoadNamespaces(node, ns.Namespaces);
            }
        }

        public Namespace GetNamespace(TreeNode node)
        {
            return GetMetadata(node)?.Namespace;
        }

        public NodeType GetNodeType(TreeNode node)
        {
            return GetMetadata(node)?.NodeType ?? NodeType.Namespace;
        }

        public TreeNodeMetaData GetMetadata(TreeNode node)
        {
            return node?.Tag as TreeNodeMetaData;
        }

        public TreeNode AddRoot(Project project)
        {
            return AddNode(NodeType.Root, null, project.Namespace, new TreeNodeMetaData() { 
                Project = project
            });
        }

        public TreeNode AddNamespace(TreeNode parent, Namespace ns)
        {
            return AddNode(NodeType.Namespace, parent, ns.Name, new TreeNodeMetaData()
            {
                Namespace = ns
            });
        }

        public void RemoveNode(TreeNode node)
        {
            node.Remove();
        }

        private TreeNode AddNode(NodeType nodeType, TreeNode parent, string text, TreeNodeMetaData metaData, Accessibility? accessibility = null, string type = null)
        {
            TreeNode node = new TreeNode()
            {
                ImageIndex = _imageIndices[nodeType],
                SelectedImageIndex = _imageIndices[nodeType]
            };

            if (nodeType == NodeType.Namespace)
                node.Text = $"{parent.Text}.";
            if (accessibility.HasValue)
                node.Text = $"({accessibility}) ";
            if (type != null)
                node.Text += $"{type} ";

            node.Text += text;
            metaData.NodeType = nodeType;
            node.Tag = metaData;

            (parent?.Nodes ?? Tree.Nodes).Add(node);
            return node;
        }
    }
}
