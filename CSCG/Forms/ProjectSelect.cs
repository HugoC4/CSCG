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

namespace CSCG.Forms
{
    public partial class ProjectSelect : Form
    {
        public ProjectSelect()
        {
            InitializeComponent();
            List<ProjectSummary> temp = new List<ProjectSummary>();
            for (int i = 0; i < 24; i++)
            {
                temp.Add(new ProjectSummary(i, "Trololol", DateTime.Today, DateTime.Now) { Dock = DockStyle.Top });
            }
            pjList.AddProjects(temp);
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
