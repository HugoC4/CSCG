using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class AddClass : Form
    {
        private Namespace NsParent { get; set; }
        public string ClassName => txtName.Text.Trim();
        public bool DefaultCtor => cxCtor.Checked;
        public Accessibility Accessibility => (Accessibility) cbAccess.SelectedItem;

        public AddClass()
        {
            InitializeComponent();
        }

        public AddClass(NodeType nodeType, Namespace parent)
        {
            InitializeComponent();
            Text = "Add " + (nodeType == NodeType.Class ? "Class" : nodeType == NodeType.Abstract ? "Abstract" : "Interface");
            if (nodeType == NodeType.Interface)
                cxCtor.Enabled = false;
            NsParent = parent;
            foreach (var ac in nodeType == NodeType.Interface ? Interface.AllowedAccessibilities : Class.AllowedAccessibilities)
                cbAccess.Items.Add(ac);
            cbAccess.SelectedItem = nodeType == NodeType.Interface ? Interface.DefaultAccessibility : Class.DefaultAccessibility;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(!Regex.IsMatch(txtName.Text.Trim(), @"^[_a-zA-z][_\-a-zA-z0-9]*$"))
            {
                lblError.Text = "Incorrect identifier format!";
                btnAdd.Enabled = false;
            }
            else if (NsParent.Classes.Any(p => p.Name == ClassName) || NsParent.Interfaces.Any(p => p.Name == ClassName))
            {
                lblError.Text = "This identifier already exists!";
                btnAdd.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
