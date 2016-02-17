using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Models;

namespace CSCG.Forms
{
    public partial class StartMenu : Form
    {
        private readonly static List<string> WelcomeMessages = new List<string>()
        {
            "Welcome back!",
            "Howdy there matey!",
            "You havin' a fun time over there?",
            "1 1z h4x0r...",
            "Lorem ipsum, dolor sit amet!",
            "How's the misses?",
            "User you = new User(motto: \"Go do something\");",
            "The fan!!! *shrugs*"
        };

        public StartMenu()
        {
            InitializeComponent();
            if (!Program.Db.Projects.Any())
                btnOpenProject.Enabled = false;
            /*
            foreach (string c in WelcomeMessages)
            {
                Namespace ns = new Namespace()
                {
                    Name = c.Replace(" ", "").ToLower(),
                    Project = Program.Db.Projects.First()
                };

                Program.Db.Projects.First().Namespaces.Add(ns);
            }

            Program.Db.SaveChanges();
            Console.WriteLine("Kek");
            */
        }

        protected override void OnShown(EventArgs e)
        {
            lblWelcomeMessage.Text = WelcomeMessages[new Random().Next(WelcomeMessages.Count - 1)];
            base.OnShown(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            ProjectSelect projectSelect = new ProjectSelect();
            if (projectSelect.ShowDialog(this) != DialogResult.OK)
            {
                if (!Program.Db.Projects.Any())
                   btnOpenProject.Enabled = false;
                return;
            }

            Project selectedProject = projectSelect.SelectedProject();
            projectSelect.Dispose();
            OpenProject(selectedProject);
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            ProjectCreate projectCreate = new ProjectCreate();
            if (projectCreate.ShowDialog(this) != DialogResult.OK) return;

            Project project = new Project()
            {
                Title = projectCreate.Title,
                Namespace = projectCreate.Namespace,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                DefaultAccessibility = projectCreate.Accessibility
            };

            Program.Db.Projects.Add(project);
            Program.Db.SaveChanges();

            btnOpenProject.Enabled = true;
            projectCreate.Dispose();
            OpenProject(project);
        }

        private void OpenProject(Project project)
        {
            MainProgram main = new MainProgram(project);
            Hide();
            var result = main.ShowDialog(this);
            Show();
            if (result != DialogResult.OK)
            {
                // Fail?
            }
            else
            {
                // Success?
            }
            main.Dispose();
        }
    }
}
