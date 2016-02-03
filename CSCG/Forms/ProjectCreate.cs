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

namespace CSCG.Forms
{
    public partial class ProjectCreate : Form
    {
        public string Title => txtTitle.Text.Trim();
        public string Namespace => txtNamespace.Text.Trim();

        private bool CorrectTitle { get; set; } = false;
        private bool CorrectNamespace { get; set; } = false;

        public ProjectCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void Validate(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Length >= 3 && txtTitle.Text.Trim().Length <= 64
                && Regex.IsMatch(txtNamespace.Text.Trim(), @"^[_a-zA-z][_\-a-zA-z0-9]*(\.[_a-zA-z]([_\-a-zA-z0-9]*))*$"))
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
    }
}
