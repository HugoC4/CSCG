﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class AddNamespace : Form
    {
        private Namespace NsParent { get; set; }
        public string Namespace => txtName.Text.Trim();

        public AddNamespace()
        {
            InitializeComponent();
        }

        public AddNamespace(Namespace parent)
        {
            InitializeComponent();
            NsParent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(!Regex.IsMatch(txtName.Text.Trim(), @"^[_a-zA-z][_\-a-zA-z0-9]*$"))
            {
                lblError.Text = "Incorrect namespace format!";
                btnAdd.Enabled = false;
            }
            else if (NsParent.Namespaces.Any(p => p.Name == txtName.Text.Trim()))
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
