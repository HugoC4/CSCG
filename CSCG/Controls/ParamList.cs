using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Forms;
using CSCG.Models;

namespace CSCG.Controls
{
    public partial class ParamList : UserControl
    {
        public Dictionary<int, Parameter> Parameters
        {
            get
            {
                int i = 0;
                return lbParams.Items.Cast<object>().ToDictionary(p => i++, p => (Parameter) p);
            }
        }

        public ParamList()
        {
            InitializeComponent();
        }

        private void btnAddParam_Click(object sender, EventArgs e)
        {
            AddNamespace an = new AddNamespace(Tree.GetNamespace(tvProject.SelectedNode));

            if (an.ShowDialog(this) == DialogResult.OK)
            {
                Namespace ns = new Namespace() { Name = an.Namespace };
                Tree.GetNamespace(tvProject.SelectedNode)?.Namespaces.Add(ns);
                Program.Db.SaveChanges();
                Tree.AddNamespace(tvProject.SelectedNode, ns);
                tvProject.SelectedNode.Expand();
            }

            an.Dispose();
        }
    }
}
