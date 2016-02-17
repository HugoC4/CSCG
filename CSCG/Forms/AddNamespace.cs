using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class AddNamespace : Form
    {
        private Namespace NsParent { get; set; }
        private Project PrParent { get; set; }
        public string Namespace => textBox1.Text.Trim();

        public AddNamespace()
        {
            InitializeComponent();
        }

        public AddNamespace(Namespace parent)
        {
            InitializeComponent();
            NsParent = parent;
        }

        public AddNamespace(Project parent)
        {
            InitializeComponent();
            PrParent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(!Regex.IsMatch(textBox1.Text.Trim(), @"^[_a-zA-z][_\-a-zA-z0-9]*(\.[_a-zA-z]([_\-a-zA-z0-9]*))*$"))
            {
                lblError.Text = "Incorrect namespace format!";
                btnAdd.Enabled = false;
            }
            else if ((NsParent?.Namespaces ?? PrParent?.Namespaces).Any(p => p.Name == textBox1.Text.Trim()))
            {
                lblError.Text = "This namespace already exists!";
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
