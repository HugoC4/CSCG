using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private ProjectSelect ProjectSelect { get; set; }

        public StartMenu()
        {
            InitializeComponent();
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
            if (projectSelect.ShowDialog(this) != DialogResult.OK) return;

            // TODO: Load existing project!
        }
    }
}
