using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class AddCtor : Form
    {
        private Class Class { get; set; }

        public AddCtor()
        {
            InitializeComponent();
        }

        public AddCtor(Class cls)
        {
            InitializeComponent();
            Class = cls;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
