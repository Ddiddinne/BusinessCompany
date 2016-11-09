﻿using System;
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
            InitializeComponent();
            this.IsMdiContainer = true;
            int i = 0;


            foreach (Project project in listProjects.ListProject)
            {
                AfficheProject afficheProject = new AfficheProject(false, project, this);
                afficheProject.MdiParent = this;
                afficheProject.Location = new Point(200, i * 150);
                i++;
                afficheProject.Dock = DockStyle.None;
                afficheProject.Enabled = true;
                afficheProject.Show();
            }

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            listProjects.Show();
            this.Close();
        }

        public void add(Project project)
        {

            listProjects.Company.addProjet(project);
            listProjects.ListProject.Remove(project);
            listProjects.Show();
            listProjects.refresh();
            this.Close();
        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            listProjects.Show();
            this.Close();
        }
    }
}