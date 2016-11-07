using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCompany
{
    public partial class AfficheProject : Form
    {
        public event EventHandler ClickButton;
        ListAddEmployee parent;
        private Project project;

        public Project Project
        {
            get { return project; }
            set { project = value; }
        }
        public AfficheProject(Boolean show, Project project/*, ListAddProject parent = null*/)
        {
            InitializeComponent();
            Name = project.Name.ToString();
            timeProject.Text = project.Delay.ToString();
            timeConcurent.Text = project.DelayCompetition.ToString();
            if (show) { add.Hide(); delete.Show(); }
        }

        public Button getButtonDelete()
        {
            return this.delete;
        }

    }
}
