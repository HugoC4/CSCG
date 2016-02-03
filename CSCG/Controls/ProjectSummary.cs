using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCG.Models;
using CSCG.Properties;

namespace CSCG.Controls
{
    public partial class ProjectSummary : UserControl
    {
        public bool Selected = false;
        private Action<object, EventArgs> GlobalOnClick { get; set; }
        public virtual Project Project { get; set; }

        public ProjectSummary(Project project)
        {
            InitializeComponent();
            
            foreach (Control ctx in new Control[] {lblId, lblTitle, lblCreated, lblUpdated})
            {
                ctx.MouseEnter += Highlight;
                ctx.MouseLeave += DeHighlight;
                ctx.Click += OnClick;
            }
            
            lblId.Text = project.ProjectId.ToString();
            lblTitle.Text = project.Title;
            lblCreated.Text = Resources.ProjectSummary_Created + project.Created.ToShortDateString();
            lblUpdated.Text = Resources.ProjectSummary_Updated + project.Updated.ToShortDateString();
            
        }
        
        private void Highlight(object sender, EventArgs e)
        {
            if (Selected) return;
            BackColor = SystemColors.ControlLight;
        }

        private void DeHighlight(object sender, EventArgs e)
        {
            if (Selected) return;
            BackColor = SystemColors.Control;
        }

        private void OnClick(object sender, EventArgs e)
        {
            GlobalOnClick?.Invoke(this, e);
        }

        public void RegisterClick(Action<object, EventArgs> method)
        {
            GlobalOnClick = method;
        }


        public void Select(bool select = true)
        {
            if (select)
            {
                BackColor = SystemColors.ControlDark;
                Selected = true;
            }
            else
            {
                BackColor = SystemColors.Control;
                Selected = false;
            }
        }
    }
}
