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
    public partial class AfficheProject : Form
    {
        ListAddProject parent;
        private Project project;

        public Project Project
        {
            get { return project; }
            set { project = value; }
        }
        public AfficheProject(Boolean show, Project project, ListAddProject parent = null)
        {
            InitializeComponent();
            this.project = project;
            this.parent = parent;
            projectName.Text = project.Name.ToString();
            timeProject.Text = project.Delay.ToString();
            timeConcurent.Text = project.DelayCompetition.ToString();
            if (show) { add.Hide(); delete.Show(); }
        }

        public Button getButtonDelete()
        {
            return this.delete;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.project;

            MessageBox.Show(this.project.Name.ToString());
            parent.add(project);
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
