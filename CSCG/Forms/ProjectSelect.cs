using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Controls;
using CSCG.Properties;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class ProjectSelect : Form
    {
        public ProjectSelect()
        {
            InitializeComponent();
        }

        public Project SelectedProject()
        {
            return pjList.SelectedProject?.Project;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!pjList.SelectedIndex.HasValue)
            {
                MessageBox.Show(Resources.ProjectSelect_btnOpen_NoProjectSelected, Resources.ProjectSelect_btnOpen_Error);
                return;
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
