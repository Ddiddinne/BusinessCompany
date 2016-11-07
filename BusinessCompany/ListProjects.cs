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
    public partial class ListProjects : Form
    {
        Company company;
        Game game;
        public ListProjects(Game game)
        {
            this.company = game.Company;
            this.game = game;
            init();
        }

        private void init()
        {
            InitializeComponent();
            DrawListEmployee(this.company.ListProjects);
        }

        public void DrawListEmployee(List<Project> listProjects)
        {
            int i = 0;
            foreach (Project project in listProjects)
            {
                AfficheProject afficheProject = new AfficheProject(true, project);
                afficheProject.TopLevel = false;
                afficheProject.Location = new Point(0, i * 100);
                i++;
                afficheProject.Show();
                afficheProject.Enabled = true;
                Button btnDelete = afficheProject.getButtonDelete();
                btnDelete.Click += new EventHandler(remove);
                afficheProject.Dock = DockStyle.None;
                this.list.Controls.Add(afficheProject);
            }
            list.Size = new Size(300, 300);
        }

        private void remove(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.Project;
            MessageBox.Show(project.Name.ToString());
            this.company.ListProjects.Remove(project);
            affiche.Hide();
            this.list.Controls.Remove(affiche);
            this.refresh();
        }

        public void refresh()
        {
            this.Controls.Clear();
            this.init();
        }

        private void addProject_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Close();
        }
    }
}
