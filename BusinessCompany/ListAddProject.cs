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
    public partial class ListAddProject : Form
    {
        
        ListProjects listProjects;
        public ListAddProject(ListProjects listProjects)
        {
            
            this.listProjects = listProjects;
            this.listProjects.game.storyGoOn += storyShow;
            InitializeComponent();
            this.BackgroundImage = listProjects.BackgroundImage;
            int i = 0;


            foreach (Project project in listProjects.ListProject)
            {
                AfficheProject afficheProject = new AfficheProject(false, project, this);
                afficheProject.Location = new Point(0, i * 155);
                afficheProject.TopLevel = false;
                i++;
                afficheProject.Dock = DockStyle.None;
                afficheProject.Enabled = true;
                afficheProject.Show();
                this.list.Controls.Add(afficheProject);
            }
            list.Size = new Size(315, 300);
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            listProjects.Show();
            this.Hide();
        }

        public void add(Project project)
        {

            listProjects.Company.addProjet(project);
            listProjects.ListProject.Remove(project);
            listProjects.Show();
            listProjects.refresh();
            this.Hide();
        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            listProjects.Show();
            this.Hide();
        }

        private void storyShow(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.listProjects.game.timer1.Stop();
                this.Hide();
                AfficheStory story = new AfficheStory(this, this.listProjects.company, this.listProjects.game.timer1, this.listProjects.game.IndexStory);
                this.listProjects.game.IndexStory++;
            }
        }
    }
}
