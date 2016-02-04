using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Code;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class MainProgram : Form
    {
        private Project Project { get; set; }
        private Dictionary<string, List<Type>> AvailableClasses { get; set; }

        private enum ViewState
        {
            Project
        }

        public MainProgram(Project project)
        {
            InitializeComponent();
            Project = project;
            AvailableClasses = GetClasses();
            TreeNode root = new TreeNode($"{project.Title} ({project.Namespace})");

            lblProjectId.Text = $"Id: {project.ProjectId}";
            lblProjectTitle.Text = $"Title: {project.Title}";
            lblProjectNamespace.Text = $"Namespace: {project.Namespace}";
            lblProjectCreated.Text = $"Created: {project.Created.ToShortDateString()} {project.Created.ToShortTimeString()}";
            lblProjectUpdated.Text = $"Updated: {project.Updated.ToShortDateString()} {project.Updated.ToShortTimeString()}";

            foreach (Namespace ns in project.Namespaces)
            {
                lvNamespaces.Items.Add(new ListViewItem() {SubItems =
                {
                    ns.NamespaceId.ToString(),
                    ns.Name,
                    $"{project.Namespace}.{ns.Name}",
                    ns.Classes.Count(p => !p.IsAbstract).ToString(),
                    ns.Classes.Count(p => p.IsAbstract).ToString(),
                    ns.Interfaces.Count().ToString()
                }});

                root.Nodes.Add(new TreeNode($"{ns.Name} ({project.Namespace}.{ns.Name})"));
            }

            tvProject.Nodes.Add(root);

            ChangeView(ViewState.Project);
        }

        private void ChangeView(ViewState state)
        {
            switch (state)
            {
                case ViewState.Project:
                    while(tcProject.TabPages.Count > 0)
                        tcProject.TabPages.RemoveAt(0);
                    tcProject.TabPages.Add(tpProject);
                    tcProject.TabPages.Add(tpNamespaces);
                    break;
            }
        }

        static Dictionary<string, List<Type>> GetClasses()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Dictionary<string, List<Type>> result = new Dictionary<string, List<Type>>();
            foreach (var assembly in assemblies)
            {
                var classes = assembly.GetTypes().Where(t => t.IsClass && t.Namespace != null && !t.Namespace.StartsWith("CSCG"));
                foreach (var cls in classes)
                    if(result.ContainsKey(cls.Namespace))
                        result[cls.Namespace].Add(cls);
                    else
                        result[cls.Namespace] = new List<Type>() {cls};
                
            }

            return result;
        }
    }
}
