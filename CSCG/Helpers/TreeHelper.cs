using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
            TreeNode root = AddNamespace(null, project.Namespace);
            LoadNamespace(root, project.Namespace);
            ExpandAllNamespaces(root);
        }

        private void ExpandAllNamespaces(TreeNode node)
        {
            if (IsNamespace(node))
            {
                node.Expand();
                foreach(TreeNode n in node.Nodes)
                    ExpandAllNamespaces(n);
            }
        }

        private void LoadNamespace(TreeNode parent, Namespace _namespace)
        {
            foreach (var ns in _namespace.Namespaces)
                LoadNamespace(AddNamespace(parent, ns), ns);
            foreach (var cls in _namespace.Classes)
                AddClass(parent, cls);
            foreach (var intf in _namespace.Interfaces)
                AddInterface(parent, intf);
        }

        private bool IsNamespace(TreeNode node)
        {
            return GetNodeType(node) == NodeType.Namespace;
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

        public TreeNode AddNamespace(TreeNode parent, Namespace ns)
        {
            return AddNode(NodeType.Namespace, parent, ns.Name, new TreeNodeMetaData()
            {
                Namespace = ns
            });
        }

        public TreeNode AddClass(TreeNode parent, Class cls)
        {
            TreeNode node =  AddNode(cls.IsAbstract ? NodeType.Abstract : NodeType.Class, parent, cls.Name, new TreeNodeMetaData()
            {
                Class = cls
            }, cls.Accessibility);
            foreach (var ctor in cls.Constructors)
            {
                AddNode(NodeType.Constructor, node, "Constructor", new TreeNodeMetaData()
                {
                    Constructor = ctor
                }, ctor.Accessibility, null, ctor.Parameters);
            }
            return node;
        }

        public TreeNode AddInterface(TreeNode parent, Interface intf)
        {
            TreeNode node = AddNode(NodeType.Interface, parent, intf.Name, new TreeNodeMetaData()
            {
                Interface = intf
            }, intf.Accessibility);
            return node;
        }

        public void RemoveNode(TreeNode node)
        {
            node.Remove();
        }

        private TreeNode AddNode(NodeType nodeType, TreeNode parent, string text, TreeNodeMetaData metaData, Accessibility? accessibility = null, string type = null, Dictionary<int, Parameter> parameters = null)
        {
            parameters = parameters ?? new Dictionary<int, Parameter>();
            TreeNode node = new TreeNode()
            {
                ImageIndex = _imageIndices[nodeType],
                SelectedImageIndex = _imageIndices[nodeType]
            };

            if (nodeType == NodeType.Namespace && parent?.Text != null)
                node.Text = $"{parent.Text}.";
            if (accessibility.HasValue)
            {
                node.Text = $"{accessibility.Value} ";
                metaData.Accessibility = accessibility.Value;
            }
            if (type != null)
                node.Text += $"{type} ";

            node.Text += text;
            if (nodeType == NodeType.Constructor || nodeType == NodeType.Method)
                node.Text += $"({string.Join(", ", parameters.Select(p => p.Value.Name))})";

            metaData.NodeType = nodeType;
            node.Tag = metaData;

            (parent?.Nodes ?? Tree.Nodes).Add(node);
            return node;
        }
    }
}
