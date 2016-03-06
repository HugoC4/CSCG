using System;
using System.Linq;
using System.Windows.Forms;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!pjList.SelectedIndex.HasValue)
            {
                MessageBox.Show(Resources.ProjectSelect_btnOpen_NoProjectSelected, Resources.ProjectSelect_btnOpen_Error);
                return;
            }

            if ( MessageBox.Show($"Are you sure you want to delete {pjList.SelectedProject.Project.Title}?",
                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.Db.Projects.Remove(Program.Db.Projects.Single(p => p.ProjectId == pjList.SelectedProject.Project.ProjectId));
                pjList.RemoveProject(pjList.SelectedIndex.Value);
                Program.Db.SaveChanges();
                if (!Program.Db.Projects.Any())
                {
                    btnCancel_Click(null, null);
                }
            }
        }
    }
}
