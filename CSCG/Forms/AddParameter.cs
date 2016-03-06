using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CSCG.Controls;
using CSCG.Helpers;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class AddParameter : Form
    {
        public Parameter Parameter { get; set; }
        private ParamList ParamList { get; set; }

        public AddParameter()
        {
            InitializeComponent();
        }
        /*
        public AddParameter(ParamList list)
        {
            InitializeComponent();
            foreach(var ns in )
                cbNamespace.Items.Add(ns.)
            foreach (var kv in TypeHelper.GetClasses())
                cbNamespace.Items.Add(kv.Value);
            
            ParamList = list;
        }

        public LoadNamespace(Namespace ns)
        {
            
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(!Regex.IsMatch(txtName.Text.Trim(), @"^[_a-zA-z][_\-a-zA-z0-9]*$"))
            {
                lblError.Text = "Incorrect identifier format!";
                btnAdd.Enabled = false;
            }
            else if (ParamList.Parameters.Any(p => p.Value.Name == txtName.Text.Trim()))
            {
                lblError.Text = "This parameter name already exists!";
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
