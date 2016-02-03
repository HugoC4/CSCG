using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCG.Controls
{
    public partial class ProjectList : UserControl
    {
        private Dictionary<int, ProjectSummary>  ProjectSummaries { get; set; } = new Dictionary<int, ProjectSummary>();
        public int? SelectedIndex { get; set; }
        public virtual ProjectSummary SelectedProject { get; set; }

        public ProjectList()
        {
            InitializeComponent();
        }

        public void AddProjects(List<ProjectSummary> summaries)
        {
            foreach (ProjectSummary pjs in summaries)
            {
                pjs.RegisterClick(OnProjectClick);
                pnlList.Controls.Add(pjs);
                ProjectSummaries.Add(ProjectSummaries.Count, pjs);
            }
        }

        public void OnProjectClick(object sender, EventArgs e)
        {
            ProjectSummary pjs = sender as ProjectSummary;
            if (pjs == null) return;

            if (!pjs.Selected)
            {
                var kvp = ProjectSummaries.SingleOrDefault(p => p.Value == pjs);

                if (kvp.Value == null) return;

                if (SelectedIndex.HasValue && SelectedIndex != kvp.Key)
                    ProjectSummaries[SelectedIndex.Value].Select(false);

                pjs.Select();
                SelectedIndex = kvp.Key;
                SelectedProject = kvp.Value;
            }
            else
            {
                pjs.Select(false);
                SelectedIndex = null;
                SelectedProject = null;

            }

        }

    }
}
